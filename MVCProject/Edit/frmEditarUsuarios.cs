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
            textBox1.Text = usuariosRow.Nome;
            textBox2.Text = usuariosRow.Login;
            textBox3.Text = usuariosRow.Senha;
            textBox4.Text = usuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Usuario editar = new Usuario();
            editar.Id = usuariosRow.Id;
            editar.Nome = textBox1.Text;
            editar.Login = textBox2.Text;
            editar.Senha = textBox3.Text;
            editar.Email = textBox4.Text;
            editar.UsuAlt = 1;
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
