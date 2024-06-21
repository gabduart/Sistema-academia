using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //precisa
using System.Data.SqlClient;//precisa

namespace ProjetoAcademia.DAL
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BDAcademia;Integrated Security=True");

        public SqlConnection Conectar()
        {
            if(con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                } catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar {ex.Message}");
                }
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();    
        }
    }
}
