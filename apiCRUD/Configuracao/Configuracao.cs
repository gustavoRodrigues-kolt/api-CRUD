using System;
using BD;
using Usuario;

namespace Configuracao
{
    public class Configuracao
    {
        public void RegistroUsuario(string nome, string telefone, string email)
        {
            Conexao con = new Conexao();
            Usuario Usu = new Usuario();

            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario VALUES (@id, @nome, @telefone, @email)", con.Myconnection)
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Text, 100);
            SqlParameter nomeParam = new SqlParameter("@nome", SqlDbType.Text, 100);
            SqlParameter emailParam = new SqlParameter("@email", SqlDbType.Text, 100);
            SqlParameter telefoneParam = new SqlParameter("@telefone", SqlDbType.Text. 100);

            idParam.Value = Id;
            nomeParam.Value = nome;
            emailParam.Value = email;
            telefoneParam.Value = telefone;

            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(nomeParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(telefoneParam);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Fechar();

        }
        public List<Usuario> AcessarUsuarioPorId(string id)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE Id = CONVERT(Varchar, @id)", con.MyConnection);
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Text, 50);
            idParam.value = id;
            cmd.Parameters.Add(idParam);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Usuario> Usuario = new List<Usuario>();

            if(reader.Read())
            {
                Usuairo Usu = new Usuario( reader["Nome"].ToString(), reader["email"].ToString(), reader["telefone"].ToString());
                Usu.Id = reader ["Id"].ToString();
                Usuario.Add(Usu);

            } 

                reader.Close();
                cmd.ExecuteNonQuery();
                con.Fechar();
                return Usuario;
        }

        public List<Usuario> AcessarUsuario()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario ", con.MyConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            list<Usuario> Usuario = new List<Usuario>();

            while(reader.Read())
            {
                Usuario Usu = new Usuario( reader["Nome"].ToString(), reader["Email"].ToString(), reader["Telefone"].ToString());
                Usu.Id = reader["Id"].ToString();
                Usuario.Add(Usu);
            }

                reader.Close();
                cmd.ExecuteNomQuery();
                con.Fechar();
                return Usuario;

        }

        public void AtualizarUsuario(string id, string nome, string email, string telefone)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("UPDATE Usuario set nome=@nome, email=@email, telefone=@telefone WHERE id=CONVERT(VARCHAR, @id)", con.MyConnection);
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Text, 10);
            SqlParameter nomeParam = new SqlParameter("@nome", SqlDbType.Texte, 100);
            SqlParameter emailParam = new SqlParameter("@email", SqlDbType.Texte, 100);
            SqlParameter telefone = new SqlParameter("@telefone", SqlDbType.Texte, 100);
            idParam.Value = id;
            nomeParam.Value = nome;
            emailParam.Value = email;
            telefoneParam.Value = telefone;
            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(nomeParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameterns.Add(telefoneParam);
            cmd.Prepara();
            cmd.ExecuteNonQuery();
            cmd.Fechar;
        }

        public void ExcluirUsuario(string id)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id=Convert(Varchar, @id)", con.MyConnection);
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Text, 10);
            idParam.Value = id;
            cmd.Parameters.Add(idParam);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Fechar();
        }

    }

}
