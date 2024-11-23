using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReciclaMais.Models;

namespace ReciclaMais.Controllers
{
    public class MunicipesController : Controller
    {
        private readonly AppDbContext _context;

        public MunicipesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Municipes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Municipes.ToListAsync());
        }

        // GET: Municipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipe = await _context.Municipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (municipe == null)
            {
                return NotFound();
            }

            return View(municipe);
        }

        // GET: Municipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Municipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cpf,Sobrenome,DataNascimento,Pontuacao,Id,Nome,Estado,Cidade,Bairro,Rua,Numero,Complemento,Cep,Telefone,Email,Username,Password,Tipo")] Municipe municipe)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before saving it to the database
                municipe.Password = BCrypt.Net.BCrypt.HashPassword(municipe.Password);

                _context.Add(municipe);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Cadastro realizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View(municipe);
        }


        // GET: Municipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipe = await _context.Municipes.FindAsync(id);
            if (municipe == null)
            {
                return NotFound();
            }
            return View(municipe);
        }

        // POST: Municipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cpf,Sobrenome,DataNascimento,Pontuacao,Id,Nome,Estado,Cidade,Bairro,Rua,Numero,Complemento,Cep,Telefone,Email,Username,Password,Tipo")] Municipe municipe)
        {
            if (id != municipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(municipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MunicipeExists(municipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(municipe);
        }

        // GET: Municipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipe = await _context.Municipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (municipe == null)
            {
                return NotFound();
            }

            return View(municipe);
        }

        // POST: Municipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var municipe = await _context.Municipes.FindAsync(id);
            if (municipe != null)
            {
                _context.Municipes.Remove(municipe);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MunicipeExists(int id)
        {
            return _context.Municipes.Any(e => e.Id == id);
        }
    }
}
