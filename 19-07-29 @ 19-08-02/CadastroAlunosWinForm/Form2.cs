using CadastroAlunosWinForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunosWinForm
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        public Aluno aluninho = new Aluno();

        private void Button1_Click(object sender, EventArgs e)
        {
            aluninho.Nome = tbxNome.Text;
            aluninho.Idade = (int) nmIdade.Value;

            this.Close();
        }
    }
}
