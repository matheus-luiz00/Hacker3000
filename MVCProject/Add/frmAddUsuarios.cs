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

namespace MVCProject.Add
{
    public partial class frmAddUsuarios : Form
    {
        public frmAddUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Usuario add = new Usuario();
            add.Nome = textBox2.Text;
            add.Login = textBox1.Text;
            add.Senha = textBox3.Text;
            add.Email = textBox4.Text;

            usuariosTableAdapter1.Insert(
                add.Nome,
                add.Login,
                add.Senha,
                add.Email,
                add.Ativo,
                add.UsuInc,
                add.UsuAlt,
                add.DatInc,
                add.DatAlt
                );

            this.Close();
        }
    }
}
