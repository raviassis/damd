using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumMonitoria.Data;
using ForumMonitoria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ForumMonitoria.Controllers
{
    [Route("[controller]/{idDisciplina}")]
    public class PaginaDisciplinaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PaginaDisciplinaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? idDisciplina)
        {
            if (idDisciplina == null)
            {
                return NotFound();
            }

            var disciplina = await _context.Disciplina
                .FirstOrDefaultAsync(m => m.ID == idDisciplina);
            disciplina.Topicos = await _context.Topico.Where(t => t.DisciplinaID == disciplina.ID).ToListAsync();
            if (disciplina == null)
            {
                return NotFound();
            }
            var topicos = disciplina.Topicos;

            return View(disciplina);
        }

        [HttpGet("CreateTopico")]
        public IActionResult CreateTopico(int? idDisciplina)
        {
            if (idDisciplina == null)
            {
                return NotFound();
            }

            var disciplina = _context.Disciplina.FirstOrDefault(d => d.ID == idDisciplina);

            if (disciplina == null)
            {
                return NotFound();
            }
            ViewData["NomeDisciplina"] = disciplina.Name;
            ViewData["IDDisciplina"] = disciplina.ID;
            return View();
        }

        [HttpPost("CreateTopico")]
        public async Task<IActionResult> CreateTopico(int? idDisciplina, Topico topico)
        {
            if (idDisciplina == null)
            {
                return NotFound();
            }
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.ID == idDisciplina);

            if (disciplina == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Add(topico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["NomeDisciplina"] = disciplina.Name;
            ViewData["IDDisciplina"] = disciplina.ID;
            return View();
        }
    }
}