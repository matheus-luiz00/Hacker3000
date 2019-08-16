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
    public partial class TelaListar : Form
    {
        List<Aluno> aluList;
        public TelaListar(List<Aluno> al)
        {
            aluList = al;
            InitializeComponent();
            
        }

        public void ListarLista()
        {
            this.listView1.BeginUpdate();
            foreach (var item in aluList)
            {

                this.listView1.Items.Add($"Aluno: {item.Nome} | Idade: {item.Idade}");
                
            }
            this.listView1.EndUpdate();
        }
    }
}
