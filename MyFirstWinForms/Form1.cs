using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForms
{
    public partial class Form1 : Form
    {
        int countPress = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Juntos e shallow now");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            countPress++;
            MessageBox.Show($"Cick event:{countPress}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"VOCÊ HACKEOU O SERGIUM MOURUM!!!");
            MessageBox.Show($"SEU BANDIDINHO!!!");
            MessageBox.Show($"VOCÊ VAI SENTIR O PESO DA LEI!!!");
            MessageBox.Show($"Advogado Paloma");

            this.Close();

        }
    }

}
