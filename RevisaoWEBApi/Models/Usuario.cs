using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class Usuario : UserControls
    {
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaLogin)]
        public string Login { get; set; }
        [MaxLength(16, ErrorMessage = "O campo excedeu o limite de 16 caracteres")]
        [MinLength(8, ErrorMessage = "O campo não atingiu um mínimo de 8 caracteres")]

        [CustomValidFields(Enums.ValidFields.ValidaSenha)]
        public string Senha { get; set; }
    }
}