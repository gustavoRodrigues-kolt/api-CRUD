using System;

namespace Usuario
{
    public class Usuario
    {
        public Usuario()
        {
            this.Nome = "";
            this.Telefone = "";
            this.Email = "";
        }

        publuc Usuario(string nome, string telefone, string email, string id)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            IdAleatorio(); //this.Id = id;  or IdAleatorio();
        }
    
    public string Id { get; set; } 
    public string Nome { get; set; } // private string name; get { return nome; } set { nome = value; } 
    public string Email { get; set; }
    public string Telefome { get; set; }

    private void IdAleatorio()
    {
        var chars = "QWERTYUIOPASDFGHJKLZXCVBNM0987654321";
        var random = new Random(); -> pegar aleatoriamente
        var resulte = new string(Enumerable.Reapeat(chars, 4).Select(s => s[random.Next(s.Lenght)]).ToArray());
        this.Id = result;
    }
    
    }
}
