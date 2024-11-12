using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciclaMais.Models;

namespace ReciclaMais.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly AppDbContext _context;

        public NoticiasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Noticias.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                _context.Noticias.Add(noticia);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(noticia);
        }
    }
}
          
