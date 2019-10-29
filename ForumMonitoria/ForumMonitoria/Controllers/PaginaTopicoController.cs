using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumMonitoria.Data;
using ForumMonitoria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumMonitoria.Controllers
{
    [Route("PaginaDisciplina/{idDisciplina}/[controller]/{idTopico}")]
    public class PaginaTopicoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaginaTopicoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? idDisciplina, int? idTopico)
        {
            if (idDisciplina == null || idTopico == null)
            {
                return NotFound();
            }

            var topico = _context.Topico.FirstOrDefault(t => t.ID == idTopico && t.DisciplinaID == idDisciplina);

            if (topico == null)
            {
                return NotFound();
            }

            topico.Mensagens = _context.Mensagem.Where(m => m.TopicoID == topico.ID).ToList();

            return View(topico);
        }

        [HttpGet("CreateMensagem")]
        public IActionResult CreateMensagem(int? idDisciplina, int? idTopico)
        {
            if (idDisciplina == null || idTopico == null)
            {
                return NotFound();
            }

            var topico = _context.Topico.FirstOrDefault(t => t.ID == idTopico && t.DisciplinaID == idDisciplina);

            if (topico == null)
            {
                return NotFound();
            }

            ViewData["NomeTopico"] = topico.Nome;
            ViewData["IDTopico"] = topico.ID;
            return View();
        }

        [HttpPost("CreateMensagem")]
        public async Task<IActionResult> CreateMensagem(int? idDisciplina, int? idTopico, Mensagem mensagem)
        {
            if (idDisciplina == null || idTopico == null)
            {
                return NotFound();
            }

            var topico = _context.Topico.FirstOrDefault(t => t.ID == idTopico && t.DisciplinaID == idDisciplina);

            if (topico == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Add(mensagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["NomeTopico"] = topico.Nome;
            ViewData["IDTopico"] = topico.ID;
            return View();
        }
    }
}