using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // PRECISA
using System.Data.SqlClient; // PRECISA

namespace ProjetoAcademia.DAL
{
    class AlunoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Aluno
                                (Nome, CPF, Email, Telefone)
                                VALUES (@Nome, @CPF, @Email, @Telefone)";
            cmd.Parameters.AddWithValue("@Nome", alu.Nome);
            cmd.Parameters.AddWithValue("@CPF", alu.Cpf);
            cmd.Parameters.AddWithValue("@Email", alu.Email);
            cmd.Parameters.AddWithValue("@Telefone", alu.Telefone);

            cmd.Connection = con.Conectar(); // Abrir conexão
            cmd.ExecuteNonQuery(); // Executar comando
            con.Desconectar(); // Fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Aluno", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt); // Preencher tabela
            con.Desconectar(); // Fechar conexão
            return dt; // Retornar dados
        }

        public void Excluir (BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Aluno WHERE IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", alu.Idaluno);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Aluno Retornar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Aluno WHERE IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", alu.Idaluno);
            cmd.Connection = con.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                alu.Idaluno = Convert.ToInt16(dr["IdAluno"]);
                alu.Nome = dr["Nome"].ToString();
                alu.Cpf = dr["CPF"].ToString();
                alu.Email = dr["Email"].ToString();
                alu.Telefone = dr["Telefone"].ToString();
            }
            dr.Close();
            con.Desconectar();
            return alu;
        }

        public void Atualizar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Aluno SET
                Nome = @Nome,
                CPF = @CPF,
                Email = @Email,
                Telefone = @Telefone
                WHERE IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@Nome", alu.Nome);
            cmd.Parameters.AddWithValue("@CPF", alu.Cpf);
            cmd.Parameters.AddWithValue("@Email", alu.Email);
            cmd.Parameters.AddWithValue("@Telefone", alu.Telefone);
            cmd.Parameters.AddWithValue("@IdAluno", alu.Idaluno);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Pesquisar(BLL.Aluno alu)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Aluno WHERE Nome LIKE @Nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + alu.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}
