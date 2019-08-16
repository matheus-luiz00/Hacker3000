using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        public Vendas vendasClass;
        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.databaseGiomarDataSet1.Carros);
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.databaseGiomarDataSet1.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendasClass = new Vendas();

            vendasClass.Carro = (int) comboBox1.SelectedValue;
            vendasClass.Quantidade = (int)numericUpDown1.Value;
            vendasClass.Valor = numericUpDown2.Value;

            this.Close();


        }
    }
}
