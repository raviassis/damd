using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ForumMonitoria.Data;
using ForumMonitoria.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumMonitoria.Controllers
{
    [Route("PaginaDisciplina/{idDisciplina}/[controller]/{idTopico}")]
    public class PaginaTopicoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _user;

        public PaginaTopicoController(ApplicationDbContext context, UserManager<ApplicationUser> user)
        {
            _context = context;
            _user = user;
        }

        public IActionResult Index(int? idDisciplina, int? idTopico)
        {
            if (idDisciplina == null || idTopico == null)
            {
                return NotFound();
            }

            var topico = _context.Topico
                                .Include(t => t.Mensagens)
                                .ThenInclude(mensagem => mensagem.User)
                                .FirstOrDefault(t => t.ID == idTopico && t.DisciplinaID == idDisciplina);

            if (topico == null)
            {
                return NotFound();
            }

            //topico.Mensagens = _context.Mensagem.Where(m => m.TopicoID == topico.ID).ToList();
            //foreach (var mensagem in topico.Mensagens)
            //{
            //    mensagem.User = _context.Users.FirstOrDefault(u => u.Id == mensagem.UserId);
            //}
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
                mensagem.UserId = _user.GetUserId(HttpContext.User);
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