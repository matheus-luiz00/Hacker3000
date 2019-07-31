using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizaçãoDeValores.Model;

namespace TabelaDeVisualizaçãoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Contrac> listContracts = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            listContracts.Add(new Contrac()
            {
                Id = listContracts.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            }
            ) ;

            BindList();
        }

        private void BindList()
        {
            var newList = new List<Contrac>();
            newList.AddRange(listContracts);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var columnId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var columnValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch(e.ColumnIndex)
                {
                    case 0:
                        {
                            MessageBox.Show("Nao é possível ajustar esta coluna.");
                            break;
                        }
                    case 1: {
                            if
                              (MessageBox.Show("Deseja realmente ajustar este valor?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listContracts.FirstOrDefault(x => x.Id == (int)columnId.Value).Value = (int) columnValue.Value;
                            }

                        } break;
                    case 2: {
                            var dialogResult = MessageBox.Show("Deseja realmente ajustar este valor?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if
                              (dialogResult == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(columnValue.Value.ToString());

                                if (dataInformada <= DateTime.Now)
                                {
                                    listContracts.FirstOrDefault(x =>
                                    x.Id == (int)columnId.Value).DatInc = DateTime.Parse(columnValue.Value.ToString());
                                } else
                                {
                                    MessageBox.Show("Não foi possível alterar o valor");
                                }
                            }

                        } break;

                }
            }
            BindList();
        }
    }
}
