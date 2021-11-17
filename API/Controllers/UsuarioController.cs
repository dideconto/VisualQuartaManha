using System.Linq;
using API.Data;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        //POST: /api/usuario/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            usuario.Senha = "";
            return Created("", usuario);
        }

        //GET: /api/usuario/get
        [Route("login")]
        [HttpGet]
        public IActionResult Login([FromBody] Usuario usuario)
        {
            usuario = _context.Usuarios.FirstOrDefault(u =>
                u.Email == usuario.Email && u.Senha == usuario.Senha);
            if (usuario == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            usuario.Token = TokenService.CriarToken(usuario);
            usuario.Senha = "";
            return Ok(usuario);
        }

        //GET: /api/usuario/sem
        [Route("sem")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Sem()
        {
            return Ok(new { message = "Usuário não autenticado" });
        }

        //GET: /api/usuario/com
        [Route("com")]
        [HttpGet]
        [Authorize]
        public IActionResult Com()
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u =>
                u.Email == User.Identity.Name);
            return Ok(new { message = usuario });
        }

        //GET: /api/usuario/permissao
        [Route("permissao")]
        [HttpGet]
        [Authorize(Roles = "adm")]
        public IActionResult Permissao()
        {
            return Ok(new { message = "Usuário administrador" });
        }

    }
}