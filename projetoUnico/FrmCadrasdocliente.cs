using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace projetoUnico
{
    public partial class FrmCadrasdocliente : Form
    {
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;

        // var que pega os ID
        string Id;
        string Foto;//recebe foto
        string AlterouFoto="nao";//altera foto
        //private string CpfAntigo;
        private void FormatarGD()
        {
            Grid.Columns[0].HeaderText = "Codigo";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Cpf";
            Grid.Columns[3].HeaderText = "Telefone";
            Grid.Columns[4].HeaderText = "Endereço";
            Grid.Columns[5].HeaderText = "Email";
            Grid.Columns[6].HeaderText = "foto";

            Grid.Columns[6].Visible = false;
            Grid.Columns[0].Visible = false;
        }

     

        public FrmCadrasdocliente()
        {
            InitializeComponent();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            LimparCampos();
            LimparFoto();
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
            sql =  "INSERT INTO  cliente (nome,Cpf,telefone,endereco,email,Image) VALUES (@nome,@Cpf,@telefone,@endereco,@email,@Image)";
            cmd =new MySqlCommand(sql,con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Image", img());

            //verifica cpf
            MySqlCommand cmdverifica;
            cmdverifica = new MySqlCommand("SELECT *FROM cliente WHERE Cpf=@Cpf", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdverifica;
            cmdverifica.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Cpf ja cadrastado", "Cadrasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            
            
            cmd.ExecuteNonQuery();
            con.Fecharconexao();

            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;
            btncancelar.Enabled = true;


            LimparFoto();
            ListarGrid();MessageBox.Show("Dados salvos com sucesso","Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome");
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text.ToString().Trim() == "   .   .   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Digite o Cpf");
                txtCpf.Focus();
                return;
            }

                 

                con.Abrirconexao();
            sql = "UPDATE cliente SET nome=@nome, Cpf=@Cpf, Email=@Email, Telefone=@Telefone, Endereco=@Endereco";
            if (AlterouFoto == "sim")
            {
                sql += ", Image=@Image";
            }
            sql += " WHERE Id=@Id";

                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
               

            if (AlterouFoto == "sim")
            {
                cmd.Parameters.AddWithValue("@Image", img());
            }

             
            
                //verifica cpf
                MySqlCommand cmdverifica;
                cmdverifica = new MySqlCommand("SELECT * FROM cliente   WHERE Cpf=@Cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdverifica;
                cmdverifica.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cpf ja cadrastado", "Cadrasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }
            

            cmd.ExecuteNonQuery();
            con.Fecharconexao();

            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

            LimparFoto();
            ListarGrid();
            MessageBox.Show("Dados salvos com sucesso", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
                  var resultado = MessageBox.Show("Deseja cancelar esse registro", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {
                con.Abrirconexao();
                sql = "DELETE FROM cliente WHERE Id=@Id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                con.Fecharconexao();

                LimparCampos();
                LimparFoto();
                Desabilitacampos();
                Desabilitarbotoes();
                btnNovo.Enabled = true;

                ListarGrid();
               

            }


            LimparCampos();
            Desabilitacampos();
            Desabilitarbotoes();
            btnNovo.Enabled = true;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                LimparFoto();
                habilitarbotoes();
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                habilitarcampos();

                AlterouFoto = "nao";

                Id = Grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = Grid.CurrentRow.Cells[2].Value.ToString();
                txtTelefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();
                txtEndereço.Text = Grid.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = Grid.CurrentRow.Cells[5].Value.ToString();

                AlterouFoto = txtCpf.Text = Grid.CurrentRow.Cells[2].Value.ToString();

                //pegar foto
                if (Grid.CurrentRow.Cells[6].Value != DBNull.Value)
                {
                    byte[] imagem01 = (byte[])Grid.Rows[e.RowIndex].Cells[6].Value;
                    MemoryStream ms = new MemoryStream(imagem01);

                    imagem.Image = System.Drawing.Image.FromStream(ms);

                }
                else
                {
                    imagem.Image = Properties.Resources.perfil2;
                }
            }
            else
            {
                return;
            }

          
        }

        private void FrmCadrasdocliente_Load(object sender, EventArgs e)
        {
            
            ListarGrid();
            LimparFoto();

        }

       
        private void txtprocura_TextChanged(object sender, EventArgs e)
        {
            
            BuscarCpf();
            

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            AlterouFoto = "sim";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png ) |*.jpg;*.png";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                Foto = dialog.FileName.ToString();//pega ocaminho da imagem
                imagem.ImageLocation = Foto;   
            }
            else
            {
                AlterouFoto = "não";
            }
        }

        private byte[] img()
        {
            byte[] imagem_byte = null;
            if (Foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(Foto, FileMode.Open,FileAccess.Read);//padrao 

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;


        }

        //metodo limpar foto
        private void LimparFoto()
        {
            imagem.Image = Properties.Resources.perfil2;
            Foto = "ft/perfil2.png";

        }

        private void ListarGrid()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM cliente ORDER BY NOME ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.Fecharconexao();

            FormatarGD();

        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            Desabilitarbotoes();
            Desabilitacampos();
            txtNome.Focus();
            btnNovo.Enabled = true;

            ListarGrid();
            LimparFoto();
            AlterouFoto = "nao";


        }

        private void habilitarbotoes()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = true;
            btncancelar.Enabled = true;
            btnAtualizar.Enabled = true;
        }
        private void Desabilitarbotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnDeletar.Enabled = false;
            btncancelar.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        private void habilitarcampos()
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereço.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
        }
        private void Desabilitacampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereço.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereço.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void BuscarCpf()
        {
            con.Abrirconexao();
            sql = "SELECT * FROM cliente WHERE Cpf=@Cpf";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Cpf", txtprocura.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.Fecharconexao();

            FormatarGD();


        }






    }

}
