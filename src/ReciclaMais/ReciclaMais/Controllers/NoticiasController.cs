using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciclaMais.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace ReciclaMais.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NoticiasController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
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
        public async Task<IActionResult> Create(Noticia noticia, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                if (Imagem != null && Imagem.Length > 0)
                {
                    // Defina o caminho da pasta para salvar a imagem
                    string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string uniqueFileName = $"{Guid.NewGuid()}_{Imagem.FileName}";
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);

                    // Salve a imagem na pasta definida
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await Imagem.CopyToAsync(fileStream);
                    }

                    // Armazene o caminho relativo da imagem para ser salvo no banco de dados
                    noticia.Imagem = $"/images/{uniqueFileName}";
                }

                // Salva os dados da notícia no banco de dados
                _context.Noticias.Add(noticia);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(noticia);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Noticias.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Noticia noticia)
        {
            if (id != noticia.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Noticias.Update(noticia);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Noticias.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Noticias.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Noticias.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Noticias.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
          
