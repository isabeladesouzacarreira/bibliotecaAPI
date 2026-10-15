using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;

namespace SeuProjeto.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicado { get; set; }
    }
}
