using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace projetoUnico
{
    public partial class FrmMenu : Form
    {

        



        public FrmMenu()
        {
            InitializeComponent();

        }   

        private void MenuCliente_Click(object sender, EventArgs e)
        {
            FrmCadrasdocliente frm = new FrmCadrasdocliente();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadrastoProduto frm = new frmCadrastoProduto();
            frm.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            

        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendamento frm = new FrmAgendamento();
            frm.ShowDialog();
        }
    }    
}
