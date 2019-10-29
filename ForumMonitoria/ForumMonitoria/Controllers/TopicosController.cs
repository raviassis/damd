using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForumMonitoria.Data;
using ForumMonitoria.Models;

namespace ForumMonitoria.Controllers
{
    public class TopicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TopicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Topicos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Topico.Include(t => t.ApplicationUser).Include(t => t.Disciplina);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Topicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topico = await _context.Topico
                .Include(t => t.ApplicationUser)
                .Include(t => t.Disciplina)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (topico == null)
            {
                return NotFound();
            }

            return View(topico);
        }

        // GET: Topicos/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            ViewData["Disciplinas"] = new SelectList(_context.Disciplina, "ID", "Name");
            return View();
        }

        // POST: Topicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,ApplicationUserId,DisciplinaID")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", topico.ApplicationUserId);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplina, "ID", "ID", topico.DisciplinaID);
            return View(topico);
        }

        // GET: Topicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topico = await _context.Topico.FindAsync(id);
            if (topico == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", topico.ApplicationUserId);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplina, "ID", "ID", topico.DisciplinaID);
            return View(topico);
        }

        // POST: Topicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,ApplicationUserId,DisciplinaID")] Topico topico)
        {
            if (id != topico.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicoExists(topico.ID))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", topico.ApplicationUserId);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplina, "ID", "ID", topico.DisciplinaID);
            return View(topico);
        }

        // GET: Topicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topico = await _context.Topico
                .Include(t => t.ApplicationUser)
                .Include(t => t.Disciplina)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (topico == null)
            {
                return NotFound();
            }

            return View(topico);
        }

        // POST: Topicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var topico = await _context.Topico.FindAsync(id);
            _context.Topico.Remove(topico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicoExists(int id)
        {
            return _context.Topico.Any(e => e.ID == id);
        }
    }
}
