using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Models;
using Beneficio.Models;

namespace Beneficio.Controllers
{
    public class BeneficioModelsController : Controller
    {
        private readonly AppDbContext _context;

        public BeneficioModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BeneficioModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Beneficio.ToListAsync());
        }

        // GET: BeneficioModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficioModel = await _context.Beneficio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (beneficioModel == null)
            {
                return NotFound();
            }

            return View(beneficioModel);
        }

        // GET: BeneficioModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BeneficioModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,PontuacaoUnitaria")] BeneficioModel beneficioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beneficioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beneficioModel);
        }

        // GET: BeneficioModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficioModel = await _context.Beneficio.FindAsync(id);
            if (beneficioModel == null)
            {
                return NotFound();
            }
            return View(beneficioModel);
        }

        // POST: BeneficioModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,PontuacaoUnitaria")] BeneficioModel beneficioModel)
        {
            if (id != beneficioModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beneficioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeneficioModelExists(beneficioModel.Id))
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
            return View(beneficioModel);
        }

        // GET: BeneficioModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficioModel = await _context.Beneficio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (beneficioModel == null)
            {
                return NotFound();
            }

            return View(beneficioModel);
        }

        // POST: BeneficioModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beneficioModel = await _context.Beneficio.FindAsync(id);
            if (beneficioModel != null)
            {
                _context.Beneficio.Remove(beneficioModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeneficioModelExists(int id)
        {
            return _context.Beneficio.Any(e => e.Id == id);
        }
    }
}
