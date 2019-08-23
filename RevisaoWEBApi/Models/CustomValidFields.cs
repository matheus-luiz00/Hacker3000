using RevisaoWEBApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields  type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {

                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        {
                            return ValidarLogin(value);
                        }
                    case ValidFields.ValidaEmail:
                        {
                            return ValidarEmail(value, validationContext.DisplayName);
                        }
                    case ValidFields.ValidaSenha:
                        {
                            return ValidarSenha(value);
                        }
                    case ValidFields.ValidaNome:
                        {
                            return ValidarNome(value);
                        }
                }

            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatorio");
        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido");
        }

        private ValidationResult ValidarLogin(object value)
        {
            Usuario user = db.usuarios.FirstOrDefault(x => x.Login == value.ToString());

            if (user == null)
                return ValidationResult.Success;
            
            return new ValidationResult($"O usuario já existe");

        }

        private ValidationResult ValidarNome(object value)
        {
            
            var result = Regex.IsMatch(value.ToString(), @"[0-9]");

            if (!result)
                return ValidationResult.Success;

            return new ValidationResult($"Nome inválido");
        }

        private ValidationResult ValidarSenha(object value)
        {
            if (value.ToString().Length < 8)
                return new ValidationResult("A senha é menor que o mínimo de 8 caracteres");
            else if (value.ToString().Length > 16)
                return new ValidationResult("A senha é maior que o máximo de 16 caracteres");

            return ValidationResult.Success;
        }

    }


}