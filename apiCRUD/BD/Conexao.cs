using System;

namespace BD
{
    public class Conexao
    {
        publci Conexao(){
            this.connectionString = "Serve=localhost,Database=Usuario;User Id=postgres;Password=csharp;MultipleActiveResultSets=True";
            this.MyConneciton = new SqlConnection(this.connectionString);
            this.Abrir();
        }

        public string connecitonString { get; set;}
        public SqlConnection MyConnection { get; set; }

        public void Abrir(){
            try
            {
                 this.MyConnection.Open();
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("erro: {0}",ex);
            }
            public void Fechar(){
                    this.MyConnection.Clase();
            }
        }
    }
}
