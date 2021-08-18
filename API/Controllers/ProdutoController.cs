using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        //POST: /api/produto/create
        [Route("create")]
        [HttpPost]
        public Produto Create(Produto produto)
        {
            produto.Nome += " alterado";
            return produto;
        }

        public Produto GetById()
        {
            return new Produto();
        }
    }
}