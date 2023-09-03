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
    public partial class frmCadrastoProduto : Form
    {
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;

        string Id;
        public frmCadrastoProduto()
        {
            InitializeComponent();
        }

        private void frmCadrastoProduto_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

       

        private void btnNovo_Click(object sender, EventArgs e)
        {

            
            habilitarcampos();
            LimparCampos();
            txtDescriçao.Focus();

            habilitarbotoes();
            btnNovo.Enabled = false;
            btnAulaizar.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescriçao.Text.ToString().Trim() == "" || txtValor.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Paramentro não informado !", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescriçao.Text = "";
                txtDescriçao.Focus();
                return;
            }
            con.Abrirconexao();
            sql = "INSERT INTO produto(descricao,valor,Qtd,categoria,Codigo) VALUES (@descricao,@valor,@Qtd,@categoria,@Codigo)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@descricao",txtDescriçao.Text);
            cmd.Parameters.AddWithValue("@valor",txtValor.Text );
            cmd.Parameters.AddWithValue("@Qtd",txtQtd.Text );
            cmd.Parameters.AddWithValue("@categoria",CmbCategoria.Text);
            cmd.Parameters.AddWithValue("@Codigo", txtCod.Text);
            cmd.ExecuteNonQuery();
            con.Fecharconexao();


         
            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;
            btnLimpar.Enabled = true;

            ListarGrid();


            MessageBox.Show("Dados salvos", "SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnAulaizar_Click(object sender, EventArgs e)
        {
            if (txtDescriçao.Text.ToString().Trim() == "" || txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Paramentro não informado !", "Iformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescriçao.Text = "";
                txtDescriçao.Focus();
                return;
            }

            con.Abrirconexao();
            sql = "UPDATE produto SET descricao=@descricao,valor=@valor,Qtd=@Qtd,categoria=@categoria,codigo=@codigo";
            sql += " WHERE Id=@Id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@descricao", txtDescriçao.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            cmd.Parameters.AddWithValue("@Qtd", txtQtd.Text);
            cmd.Parameters.AddWithValue("@categoria", CmbCategoria.Text);
            cmd.Parameters.AddWithValue("@Codigo", txtCod.Text);
            cmd.ExecuteNonQuery();
            con.Fecharconexao();

            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

            ListarGrid();
            MessageBox.Show("Dados atualizado  com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja cancelar esse registro", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Abrirconexao();
                sql = "DELETE FROM produto WHERE id=@id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Fecharconexao();

                LimparCampos();
                Desabilitacampos();
                Desabilitarbotoes();
                btnNovo.Enabled = true;

                ListarGrid();

            }
            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

            ListarGrid();
           
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Desabilitarbotoes();
            Desabilitacampos();
            txtDescriçao.Focus();
            btnNovo.Enabled = true;

            ListarGrid();
        }

        private void GridProduct_Click(object sender, DataGridViewCellEventArgs e)
        {
           
         
                habilitarbotoes();
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                habilitarcampos();

                Id = GridProduct.CurrentRow.Cells[0].Value.ToString();
                txtDescriçao.Text= GridProduct.CurrentRow.Cells[1].Value.ToString();
                txtValor.Text= GridProduct.CurrentRow.Cells[2].Value.ToString();
                txtQtd.Text= GridProduct.CurrentRow.Cells[3].Value.ToString();
                CmbCategoria.Text= GridProduct.CurrentRow.Cells[4].Value.ToString();
                txtCod.Text= GridProduct.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void habilitarbotoes()
        {
            btnAulaizar.Enabled = true;
            btnDelete.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;

        }
        private void Desabilitarbotoes()
        {
            btnAulaizar.Enabled = false;
            btnDelete.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void habilitarcampos()
        {
            txtDescriçao.Enabled = true;
            txtValor.Enabled = true;
            txtQtd.Enabled = true;
            CmbCategoria.Enabled = true;
            txtCod.Enabled = true;


        }
        private void Desabilitacampos()
        {
            txtDescriçao.Enabled = false;
            txtValor.Enabled = false;
            txtQtd.Enabled = false;
            CmbCategoria.Enabled = false;
            txtCod.Enabled = false;

        }
        private void LimparCampos()
        {
            txtDescriçao.Text = "";
            txtQtd.Text = "";
            txtValor.Text = "";
            CmbCategoria.Text = "";
            txtCod.Text = "";
        }

        private void FormatarGD()
        {
            GridProduct.Columns[0].HeaderText = "Id";
            GridProduct.Columns[1].HeaderText = "Descrição";
            GridProduct.Columns[2].HeaderText = "Valor";
            GridProduct.Columns[3].HeaderText = "QTD";
            GridProduct.Columns[4].HeaderText = "Categoria";
            GridProduct.Columns[5].HeaderText = "Codigo";

            GridProduct.Columns[0].Visible = false;

        }
        private void ListarGrid()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM produto";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridProduct.DataSource = dt;
            con.Fecharconexao();
            FormatarGD();

        }
        private void BuscasProduto()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM produto WHERE codigo=@codigo";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@codigo", txtBuscas);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridProduct.DataSource = dt;
            con.Fecharconexao();
        }

        private void txtBuscas_TextChanged(object sender, EventArgs e)
        {
            BuscasProduto();
        }
    }
}
