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
    public partial class frmAddGenero : Form
    {
        public frmAddGenero()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Genero add = new Genero();
            add.Tipo = textBox2.Text;
            add.Descricao = textBox1.Text;

            if (!string.IsNullOrEmpty(add.Tipo))
            {
                generosTableAdapter1.Insert(
                    add.Tipo,
                    add.Descricao
                    );

                this.Close();
            }
        }
    }
}
