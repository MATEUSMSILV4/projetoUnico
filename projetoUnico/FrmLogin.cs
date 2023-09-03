using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoUnico
{
    public partial class FrmLogin : Form
    {
        conexao con = new conexao();
      
      
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "" || txtSenha.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Digite o usuario!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnome.Text = "";
                txtnome.Focus();
                return;


            }
            try
            {
                con.Abrirconexao();
                MySqlCommand cmdverificar;
                MySqlDataReader reader;
                cmdverificar = new MySqlCommand("SELECT * FROM login WHERE nome=@nome AND senha=@senha", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand= cmdverificar;
                cmdverificar.Parameters.AddWithValue("@nome", txtnome.Text);
                cmdverificar.Parameters.AddWithValue("@senha",txtSenha.Text);
                reader = cmdverificar.ExecuteReader(); 
               
                if (reader.HasRows)
                {
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();

                   
                        
                }
                else
                {
                    MessageBox.Show("Login não cadrastado!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Fecharconexao();
              

            }
            catch (Exception )
            {
                MessageBox.Show("Erro no servido entrar em contato com adminidtrador");

            }
       
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtSenha.Text = "";
        }

        
    }
}
