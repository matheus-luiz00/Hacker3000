using FormularioCarroWinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCarroWinForm
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        public Carro crr = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            crr.Ano = (int)nmAno.Value;
            crr.Modelo = tbxModelo.Text;
            crr.Placa = txtPlaca.Text;

            this.Close();
        }
    }
}
