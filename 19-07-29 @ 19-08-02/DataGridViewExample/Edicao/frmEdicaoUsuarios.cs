using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }

        public DataGridViewExample.DatabaseGiomarDataSet1.UsuariosRow usuariosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow.Usuario = textBox1.Text;
            usuariosTableAdapter1.Update(usuariosRow);


            this.Close();
        }
    }
}
