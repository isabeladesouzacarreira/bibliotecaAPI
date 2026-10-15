using bibliotecaAPI.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeuProjeto.Models;

namespace SeuProjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LivroController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> Getlivros()
        {
            return await _context.Livros.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> CriarLivro(Livro Livro)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<livro> livroEntry = _context.Livros.Add(Livro);

            await _context.SaveChangesAsync();

            return Ok("Livro cadastrado com sucesso!");
        }