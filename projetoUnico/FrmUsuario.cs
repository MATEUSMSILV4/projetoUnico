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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;
        string Id;
       


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            txtNome.Focus();



            habilitarbotoes();
            btnNovo.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text.ToString().Trim() == "   .   .   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Digite o Cpf!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }


            con.Abrirconexao();
            sql = "INSERT INTO  login (nome,Cpf,senha) VALUES (@nome,@Cpf,@senha)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            //verifica cpf
            MySqlCommand cmdverifica;
            cmdverifica = new MySqlCommand("SELECT *FROM login WHERE Cpf=@Cpf", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdverifica;
            cmdverifica.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Cpf ja cadrastado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.Fecharconexao();

            LimparCampos();
            DesabilitarCampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;
            btnLimpar.Enabled = true;

            ListarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text.ToString().Trim() == "   .   .   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Digite o Cpf!", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }


            con.Abrirconexao();
            sql = "UPDATE login SET nome=@nome, Cpf=@Cpf, senha=@senha WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            // verifica cpf
            MySqlCommand cmdverifica;
            cmdverifica = new MySqlCommand("SELECT *FROM login WHERE Cpf=@Cpf", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdverifica;
            cmdverifica.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario já cadrastado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }



            cmd.ExecuteNonQuery();
            con.Fecharconexao();


            LimparCampos();
            Desabilitarbotoes();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

            ListarGrid();
            MessageBox.Show("Dados salvos com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja cancelar esse registro", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Abrirconexao();
                sql = "DELETE FROM login WHERE id=@id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Fecharconexao();

                LimparCampos();
                DesabilitarCampos();
                Desabilitarbotoes();
                btnNovo.Enabled = true;

                ListarGrid();

            }
            LimparCampos();
            DesabilitarCampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

            ListarGrid();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();
            Desabilitarbotoes();
            DesabilitarCampos();
            txtNome.Focus();
            btnNovo.Enabled = true;

            ListarGrid();
            
        }

        private void GridUser_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                habilitarbotoes();
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                HabilitarCampos();

                Id = GridUser.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = GridUser.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = GridUser.CurrentRow.Cells[2].Value.ToString();
                txtSenha.Text = GridUser.CurrentRow.Cells[3].Value.ToString();

                ListarGrid();
            }

        }

        private void txtprocura_TextChanged(object sender, EventArgs e)
        {
            BuscarCpf();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void habilitarbotoes()
        {
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
        }
        private void Desabilitarbotoes()
        {
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtCpf.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtSenha.Text = "";
        }
        private void FormatarGD()
        {
            GridUser.Columns[0].HeaderText = "Codigo";
            GridUser.Columns[1].HeaderText = "Nome";
            GridUser.Columns[2].HeaderText = "Cpf";
            GridUser.Columns[3].HeaderText = "Senha";
        }
        private void ListarGrid()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM login ORDER BY NOME ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridUser.DataSource = dt;
            con.Fecharconexao();
            FormatarGD();

        }
        private void BuscarCpf()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM login WHERE Cpf=@Cpf";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Cpf", txtprocura.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridUser.DataSource = dt;
            con.Fecharconexao();

            FormatarGD();

        }



    }
}
