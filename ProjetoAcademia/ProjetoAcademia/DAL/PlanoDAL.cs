using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // PRECISA
using System.Data.SqlClient; // PRECISA

namespace ProjetoAcademia.DAL
{
    internal class PlanoDAL
    {
        Conexao con = new Conexao(); // incluir classe de conexao

        public void Cadastrar(BLL.Plano plano)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Plano
                                (NomePlano, Preco)
                                VALUES (@NomePlano, @Preco)";
            cmd.Parameters.AddWithValue("@NomePlano", plano.Nome);
            cmd.Parameters.AddWithValue("@Preco", plano.Preco);

            cmd.Connection = con.Conectar(); // Abrir conexão
            cmd.ExecuteNonQuery(); // Executar comando
            con.Desconectar(); // Fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Plano", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt); // Preencher tabela
            con.Desconectar(); // Fechar conexão
            return dt; // Retornar dados
        }

        public void Excluir(BLL.Plano plan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Plano WHERE IdPlano = @IdPlano";
            cmd.Parameters.AddWithValue("@IdPlano", plan.Idplano);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public BLL.Plano Retornar(BLL.Plano plan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Plano WHERE IdPlano = @IdPlano";
            cmd.Parameters.AddWithValue("@IdPlano", plan.Idplano);
            cmd.Connection = con.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                plan.Idplano = Convert.ToInt16(dr["IdPlano"]);
                plan.Nome = dr["NomePlano"].ToString();
                plan.Preco = float.Parse(dr["Preco"].ToString());
            }
            dr.Close();
            con.Desconectar();
            return plan;
        }

        public void Atualizar(BLL.Plano plan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Plano SET 
                NomePlano = @Nome,
                Preco = @Preco
                WHERE IdPlano = @IdPlano";
            cmd.Parameters.AddWithValue("@Nome", plan.Nome);
            cmd.Parameters.AddWithValue("@Preco", plan.Preco);
            cmd.Parameters.AddWithValue("@IdPlano", plan.Idplano);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public DataTable Pesquisar(BLL.Plano plan)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Plano WHERE Nome LIKE @Nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + plan.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}
