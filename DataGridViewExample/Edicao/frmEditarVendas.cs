using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEditarVendas : Form
    {
        public frmEditarVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.DatabaseGiomarDataSet1.VendasRow vendasRow;

        private void FrmEditarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.databaseGiomarDataSet1.Carros);
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.SelectComInnerJoin(this.databaseGiomarDataSet1.DataTable2);

            comboBox1.SelectedValue = vendasRow.Carro;
            numericUpDown1.Value = vendasRow.Quantidade;
            textBox1.Text = vendasRow.Valor.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendasRow.Carro = (int)comboBox1.SelectedValue;
            vendasRow.Quantidade = (int) numericUpDown1.Value;
            vendasRow.Valor = decimal.Parse(textBox1.Text);

            this.vendasTableAdapter1.Update(vendasRow);

            this.Close();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectComInnerJoinToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.SelectComInnerJoin(this.databaseGiomarDataSet1.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
