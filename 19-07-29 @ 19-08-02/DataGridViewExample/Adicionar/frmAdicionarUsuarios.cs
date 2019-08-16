using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }
        public Usuarios usuarioBanco;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioBanco = new Usuarios();
            usuarioBanco.Usuario = textBox1.Text ;

            this.Close();
        }
    }
}
