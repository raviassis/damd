using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ForumMonitoria.Models;

namespace ForumMonitoria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ForumMonitoria.Models.Disciplina> Disciplina { get; set; }
        public DbSet<ForumMonitoria.Models.Topico> Topico { get; set; }
        public DbSet<ForumMonitoria.Models.Mensagem> Mensagem { get; set; }
    }
}
