using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MVCProject
{
    public partial class Principal : Form, IMessageFilter
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public Principal()
        {
            if (Login.TelaLogin())
            {
                InitializeComponent();
                Application.AddMessageFilter(this);
                controlsToMove.Add(this);
            }
            else
                Application.Exit();
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmLocacao telaLocacao = new frmLocacao();
            telaLocacao.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLivros telaLivros = new frmLivros();
            telaLivros.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            frmEditoras telaEditoras = new frmEditoras();
            telaEditoras.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmGeneros telaGeneros = new frmGeneros();
            telaGeneros.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmAutores telaAutores = new frmAutores();
            telaAutores.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();
            telaUsuarios.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            


        }
    }
}
