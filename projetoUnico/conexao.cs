using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoUnico
{
    internal class conexao
    {
        public string conec = "SERVER=localhost;DATABASE=cadrastos; UID=root;PWD=;PORT=;";

        public MySqlConnection con = null;




        public void Abrirconexao()
        {
            try
            {
                con = new MySqlConnection(conec); 
                con.Open ();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no servido entrar em contato com adminidtrador" + ex.Message);
            }
        }

        public void Fecharconexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servido entrar em contato com adminidtrador" + ex.Message);

            }
        }


    }

}
