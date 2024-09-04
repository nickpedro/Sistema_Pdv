using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Pdv
{
    internal class Conexao
    {
        public  string conec = "SERVER=PC-PEDRO; DATABASE=pdv; Integrated Security=True;";
        public SqlConnection conn = null;

        public void AbrirConexao()
        {
            conn = new SqlConnection(conec);
            conn.Open();
        }
        public void FecharConexao()
        {
           if (conn != null)
            {
                conn.Close();
                conn.Dispose(); // Derruba algumas conexões abertas.
            }
        }
     
    }
}
