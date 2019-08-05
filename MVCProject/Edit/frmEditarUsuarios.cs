using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Model;

namespace MVCProject.Edit
{
    public partial class frmEditarUsuarios : Form
    {
        public frmEditarUsuarios()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow usuariosRow;

        private void FrmEditarUsuarios_Load(object sender, EventArgs e)
        {
            txtNome.Text = usuariosRow.Nome;
            txtLogin.Text = usuariosRow.Login;
            txtEmail.Text = usuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Crypto senhaToHash = new Crypto();
            Usuario editar = new Usuario();
            editar.Id = usuariosRow.Id;
            editar.Nome = txtNome.Text;
            editar.Login = txtLogin.Text;


            if (usuariosRow.Senha != txtSenha.Text)
                editar.Senha = senhaToHash.HashQueRetornaString(txtSenha.Text);
            else
                editar.Senha = usuariosRow.Senha;

            editar.Email = txtEmail.Text;
            editar.UsuAlt = Session.usu.Id;
            editar.DatAlt = DateTime.Now;

            usuariosTableAdapter1.UpdateQuery(
                editar.Nome,
                editar.Login,
                editar.Senha,
                editar.Email,
                editar.Ativo,
                editar.UsuAlt,
                editar.DatAlt,
                editar.Id);

            this.Close();
            
        }
    }
}
