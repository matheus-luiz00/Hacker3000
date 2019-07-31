﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.databaseGiomarDataSet1.Carros);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 marcasTela = new Form2();
            marcasTela.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormVendas vendasTela = new FormVendas();
            vendasTela.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarioTela = new FormUsuarios();
            usuarioTela.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.DatabaseGiomarDataSet1.CarrosRow;


            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                        break; }

            }
            this.carrosTableAdapter.CustomQuery(databaseGiomarDataSet1.Carros);

            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

            this.carrosTableAdapter.CustomQuery(databaseGiomarDataSet1.Carros);

        }
    }
}
