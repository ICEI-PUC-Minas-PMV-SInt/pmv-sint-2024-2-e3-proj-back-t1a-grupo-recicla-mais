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
    public class OrgaoPublicosController : Controller
    {
        private readonly AppDbContext _context;

        public OrgaoPublicosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrgaoPublicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrgaosPublicos.ToListAsync());
        }

        // GET: OrgaoPublicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgaoPublico = await _context.OrgaosPublicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgaoPublico == null)
            {
                return NotFound();
            }

            return View(orgaoPublico);
        }

        // GET: OrgaoPublicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrgaoPublicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NomeOrg,Id,Nome,Estado,Cidade,Bairro,Rua,Numero,Complemento,Cep,Telefone,Email,Username,Password,Tipo")] OrgaoPublico orgaoPublico)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before saving it to the database
                orgaoPublico.Password = BCrypt.Net.BCrypt.HashPassword(orgaoPublico.Password);

                _context.Add(orgaoPublico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orgaoPublico);
        }


        // GET: OrgaoPublicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgaoPublico = await _context.OrgaosPublicos.FindAsync(id);
            if (orgaoPublico == null)
            {
                return NotFound();
            }
            return View(orgaoPublico);
        }

        // POST: OrgaoPublicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NomeOrg,Id,Nome,Estado,Cidade,Bairro,Rua,Numero,Complemento,Cep,Telefone,Email,Username,Password,Tipo")] OrgaoPublico orgaoPublico)
        {
            if (id != orgaoPublico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgaoPublico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgaoPublicoExists(orgaoPublico.Id))
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
            return View(orgaoPublico);
        }

        // GET: OrgaoPublicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgaoPublico = await _context.OrgaosPublicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orgaoPublico == null)
            {
                return NotFound();
            }

            return View(orgaoPublico);
        }

        // POST: OrgaoPublicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orgaoPublico = await _context.OrgaosPublicos.FindAsync(id);
            if (orgaoPublico != null)
            {
                _context.OrgaosPublicos.Remove(orgaoPublico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgaoPublicoExists(int id)
        {
            return _context.OrgaosPublicos.Any(e => e.Id == id);
        }
    }
}
