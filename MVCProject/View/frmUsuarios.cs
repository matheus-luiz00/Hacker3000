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
using MVCProject.Add;
using MVCProject.Edit;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public frmUsuarios()
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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuarios frmAdd = new frmAddUsuarios();
            frmAdd.ShowDialog();
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
        MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow rowSelecionada;
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex == -1))
                rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rowSelecionada != null)
            {
                frmEditarUsuarios telaEditar = new frmEditarUsuarios();
                telaEditar.usuariosRow = rowSelecionada;
                telaEditar.ShowDialog();
                this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.DeleteQuery(rowSelecionada.Id);
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
