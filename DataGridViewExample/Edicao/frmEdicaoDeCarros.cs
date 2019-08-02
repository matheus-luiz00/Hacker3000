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
    public partial class frmEdicaoDeCarros : Form
    {
        public frmEdicaoDeCarros()
        {
            InitializeComponent();
        }

        public DataGridViewExample.DatabaseGiomarDataSet1.CarrosRow CarrosRow;

        private void FrmEdicaoDeCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.databaseGiomarDataSet1.Marcas);

            textBox1.Text = CarrosRow.Modelo;
            dateTimePicker1.Value = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.databaseGiomarDataSet1.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.databaseGiomarDataSet1.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = textBox1.Text;
            CarrosRow.Marca = (int) comboBox1.SelectedValue;
            CarrosRow.Ano = dateTimePicker1.Value;

            this.carrosTableAdapter1.Update(CarrosRow);

            this.Close();
        }
    }
}
