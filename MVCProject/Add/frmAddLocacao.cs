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
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Locacao add = new Locacao();
            add.Livro =(int)cboxLivro.SelectedValue;
            add.Usuario = (int)cboxUsuario.SelectedValue;
            add.Tipo = (int)cboxGenero.SelectedValue;
            add.Devolucao = dateTimePicker1.Value;

            locacaoTableAdapter1.Insert(
                add.Livro,
                add.Usuario,
                add.Tipo,
                add.Devolucao,
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
