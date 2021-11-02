using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Usuario : Controller
    {
        [HttpGet("listar")]
        public class Get()
        {
            Configuracao conf = new Configuracao();
            var listar = conf.AcessarUsuario();

            return new{ Lista = lista };
        }

        [HttpGet("atualizar/Id={id}/Nome={nome}/Email{email}/Telefone{telefone}")]
        public IActionResult Put(string id, string nome, string email, string telefone)
        {
            Configuracao conf = new Configuracao();
            conf.AtualizarProduto(id, nome, email, telefone);

            return Ok();
        }

        [HttoGet("excluir/{id}")]
        public IActionResult Delete(string id)
        {
            Configuracao conf = new Configuracao();
            conf.ExcluirUsuario();
            return Ok();
        }
    }
}