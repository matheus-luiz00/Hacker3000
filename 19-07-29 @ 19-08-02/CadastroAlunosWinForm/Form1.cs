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
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 telaCadastro = new Form2();
            telaCadastro.ShowDialog();
            alunos.Add(telaCadastro.aluninho);

            
            dataGridView1.DataSource = alunos;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TelaListar tela = new TelaListar(alunos);
            tela.ListarLista();
            tela.ShowDialog();

            tela.Close();
            
        }
    }
}
