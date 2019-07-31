using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.GetAllData(this.databaseGiomarDataSet1.DataTable1);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lixeiraGlobal = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.DatabaseGiomarDataSet1.DataTable1Row;


            switch (lixeiraGlobal.Tabela)
            {
                case "carros":
                    {
                        this.carrosTableAdapter1.CustomSetAtivo(lixeiraGlobal.Id);
                        break;
                    }

                case "marcas":
                    {
                        this.marcasTableAdapter1.CustomSetAtivo(lixeiraGlobal.Id);
                        break;
                    }

                case "usuarios":
                    {
                        this.usuariosTableAdapter1.CustomSetAtivo(lixeiraGlobal.Id);
                        break;
                    }

                case "vendas":
                    {
                        this.vendasTableAdapter1.CustomSetAtivo(lixeiraGlobal.Id);
                        break;
                    }

            }

            this.dataTable1TableAdapter.GetAllData(databaseGiomarDataSet1.DataTable1);
        }
    }
}
