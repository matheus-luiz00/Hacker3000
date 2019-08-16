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
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Autor add = new Autor();
            add.Nome = textBox2.Text;
            add.Descricao = textBox1.Text;

            if(!string.IsNullOrEmpty(add.Nome))
            autoresTableAdapter1.Insert(
                add.Nome,
                add.Descricao
                );

            this.Close();
        }
    }
}
