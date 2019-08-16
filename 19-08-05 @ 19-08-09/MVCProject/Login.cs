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
using System.Security.Cryptography;
using MVCProject.View;

namespace MVCProject
{
    public partial class Login : Form, IMessageFilter
    {
        bool loginPossivel = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public Login()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            controlsToMove.Add(this);
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Crypto inputToHash = new Crypto();
            var idUsu = usuariosTableAdapter1.LoginCompacto(txtUser.Text, inputToHash.HashQueRetornaString(txtPassword.Text));
            if (idUsu != null)
            {
                loginPossivel = true;
                Session.usu.Id = (int) idUsu;
                this.Close();
            } else
            {
                label3.Visible = true;
            }

        }

        public static bool TelaLogin()
        {
            Login log = new Login();
            log.ShowDialog();
            return log.loginPossivel;
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                Crypto inputToHash = new Crypto();
                var idUsu = usuariosTableAdapter1.LoginCompacto(txtUser.Text, inputToHash.HashQueRetornaString(txtPassword.Text));
                if (idUsu != null)
                {
                    loginPossivel = true;
                    Session.usu.Id = (int)idUsu;
                    this.Close();
                }
                else
                {
                    label3.Visible = true;
                }
            }
        }
    }
}

