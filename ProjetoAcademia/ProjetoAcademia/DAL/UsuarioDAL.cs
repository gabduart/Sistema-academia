using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // PRECISA
using System.Data.SqlClient; // PRECISA

namespace ProjetoAcademia.DAL
{
    class UsuarioDAL
    {
        Conexao con = new Conexao(); // incluir classe de conexao
        
        // Método cadastrar
        public void Cadastrar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Usuario
                                (Nome, Email, Senha, IsAdm)
                                VALUES (@Nome, @Email, @Senha, @Isadm)";

            cmd.Parameters.AddWithValue("@Nome", usu.Nome);
            cmd.Parameters.AddWithValue("@Email", usu.Email);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Parameters.AddWithValue("@Isadm", usu.Isadm);

            cmd.Connection = con.Conectar(); // Abrir conexão
            cmd.ExecuteNonQuery(); // Executar comando
            con.Desconectar(); // Fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuario", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt); // Preencher tabela
            con.Desconectar(); // Fechar conexão
            return dt; // Retornar dados
        }

        public void Excluir(BLL.Usuario usu)
        {   
            //Comando SQL para executar com base no Id, pois é CHAVE PRIMÁRIA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", usu.Idusuario);
            cmd.Connection = con.Conectar();//abre a conexão
            cmd.ExecuteNonQuery();//executar comando
            con.Desconectar(); //fechar conexão
        }

        // atualizar
        // retornando dados apartir do código
        public BLL.Usuario Retornar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", usu.Idusuario);
            cmd.Connection = con.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usu.Idusuario = Convert.ToInt16(dr["IdUsuario"]);
                usu.Nome = dr["Nome"].ToString();
                usu.Email = dr["Email"].ToString();
                usu.Senha = dr["Senha"].ToString();
                usu.Isadm = Convert.ToBoolean(dr["IsAdm"]);
            }
            dr.Close();
            con.Desconectar();
            return usu;
        }

        public void Atualizar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Usuario SET 
                Nome = @Nome,
                Email = @Email,
                Senha = @Senha,
                IsAdm = @IsAdm
                WHERE IdUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@Nome", usu.Nome);
            cmd.Parameters.AddWithValue("@Email", usu.Email);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Parameters.AddWithValue("@IsAdm", usu.Isadm);
            cmd.Parameters.AddWithValue("@IdUsuario", usu.Idusuario);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Pesquisar(BLL.Usuario usu)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Usuario WHERE Nome LIKE @Nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + usu.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}
