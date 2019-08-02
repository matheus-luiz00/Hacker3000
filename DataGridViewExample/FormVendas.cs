using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuerry(this.databaseGiomarDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.DatabaseGiomarDataSet1.VendasRow;


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                        break;
                    }
                case 1:
                    {
                        frmEditarVendas editar = new frmEditarVendas();
                        editar.vendasRow = vendasSelect;
                        editar.ShowDialog();
                        break;
                    }
            }

            this.vendasTableAdapter.CustomQuerry(databaseGiomarDataSet1.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas addVendas = new frmAdicionarVendas();
            addVendas.ShowDialog();

            if(addVendas.vendasClass.Carro > -1)
            this.vendasTableAdapter.Insert(
                addVendas.vendasClass.Carro,
                addVendas.vendasClass.Quantidade,
                addVendas.vendasClass.Valor,
                addVendas.vendasClass.Ativo,
                1,
                1,
                addVendas.vendasClass.DatInc,
                addVendas.vendasClass.DatAlt);

            this.vendasTableAdapter.CustomQuerry(this.databaseGiomarDataSet1.Vendas);
        }
    }
}
