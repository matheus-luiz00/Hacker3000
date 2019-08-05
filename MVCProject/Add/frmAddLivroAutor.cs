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
    public partial class frmAddLivroAutor : Form
    {
        public frmAddLivroAutor()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            LivroAutor add = new LivroAutor();
            add.Autor = (int) cboxAutor.SelectedValue;
            add.Livro = (int)cboxLivro.SelectedValue;

            livroAutorTableAdapter1.Insert(
                add.Livro,
                add.Autor
                );

            this.Close();
        }
    }
}
