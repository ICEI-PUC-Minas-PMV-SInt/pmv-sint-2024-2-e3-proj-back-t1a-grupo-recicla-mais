﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReciclaMais.Enuns;
using ReciclaMais.Models;
using System.Text.Json;

namespace ReciclaMais.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Agendamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Agendamentos.ToListAsync());
        }

        // GET: Agendamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agendamento == null)
            {
                return NotFound();
            }

            return View(agendamento);
        }

        // GET: Agendamentos/Create
        public async Task<IActionResult> Create()
        {
            var produtos = await _context.Produtos.ToListAsync();
            ViewBag.Produtos = produtos;

            // Usa o helper para obter os percentuais de cada estado de conservação.
            var estadosConservacao = EstadosConservacaoHelper.Percentuais
                .Select(kvp => new EstadoConservacaoViewModel
                {
                    Nome = kvp.Key.ToString(),
                    Percentual = kvp.Value
                })
                .ToList();

            ViewBag.EstadosConservacao = estadosConservacao;

            // Carregar os horários disponíveis do arquivo JSON.
            var horarios = ObterHorariosDisponiveis();
            ViewBag.HorariosDisponiveis = horarios;

            return View();
        }

        private List<string> ObterHorariosDisponiveis()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Config", "HorariosDisponiveis.json");

            if (!System.IO.File.Exists(filePath))
            {
                return new List<string> { "08:00 - 10:00", "12:00 - 14:00", "16:00 - 18:00" };
            }

            var jsonContent = System.IO.File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<HorariosModel>(jsonContent);

            // Retorna uma lista vazia se for nulo.
            return data?.HorariosDisponiveis ?? new List<string>();  
        }

        // Obter o percentual conforme o estado de conservação de um produto.
        private double GetPercentual(ReciclaMais.Enuns.EstadosConservacao estado)
        {
            switch (estado)
            {
                case ReciclaMais.Enuns.EstadosConservacao.Novo:
                    return 1.0;
                case ReciclaMais.Enuns.EstadosConservacao.Usado:
                    return 0.5;
                case ReciclaMais.Enuns.EstadosConservacao.Descarte:
                    return 0.1;
                default:
                    return 1.0;
            }
        }

        // POST: Agendamentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataAgendamento,Horario,ItensColeta")] Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamento);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            var produtos = await _context.Produtos.ToListAsync();
            ViewBag.Produtos = produtos;
            var estadosConservacao = EstadosConservacaoHelper.Percentuais
                .Select(kvp => new EstadoConservacaoViewModel
                {
                    Nome = kvp.Key.ToString(),
                    Percentual = kvp.Value
                })
                .ToList();
            ViewBag.EstadosConservacao = estadosConservacao;

            var horarios = ObterHorariosDisponiveis();
            ViewBag.HorariosDisponiveis = horarios;

            return View(agendamento);
        }

        // GET: Agendamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamentos.FindAsync(id);
            if (agendamento == null)
            {
                return NotFound();
            }
            return View(agendamento);
        }

        // POST: Agendamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataAgendamento,Horario,PontuacaoTotal")] Agendamento agendamento)
        {
            if (id != agendamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agendamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendamentoExists(agendamento.Id))
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
            return View(agendamento);
        }

        // GET: Agendamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agendamento == null)
            {
                return NotFound();
            }

            return View(agendamento);
        }

        // POST: Agendamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agendamento = await _context.Agendamentos.FindAsync(id);
            if (agendamento != null)
            {
                _context.Agendamentos.Remove(agendamento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendamentoExists(int id)
        {
            return _context.Agendamentos.Any(e => e.Id == id);
        }
    }
}
