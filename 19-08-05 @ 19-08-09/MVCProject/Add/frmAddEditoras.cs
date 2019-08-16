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
    public partial class frmAddEditoras : Form
    {
        public frmAddEditoras()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Editora add = new Editora();
            add.Nome = textBox2.Text;
            add.Descricao = txtDesc.Text;

            if(!string.IsNullOrEmpty(add.Nome))
            editorasTableAdapter1.Insert(
                add.Nome,
                add.Descricao
                );
            this.Close();
        }
    }
}
