using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Dados
{
    public class Conexao
    {
        public string Cn = "Data Source=DESKTOP-UPFUDB4;initial catalog=Academia;integrated Security=true";

        public SqlConnection Con = null;

        public void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(Cn);
                Con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                Con = new SqlConnection(Cn);
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }
}
