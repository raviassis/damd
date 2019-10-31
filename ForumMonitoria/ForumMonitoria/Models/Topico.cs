using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumMonitoria.Models
{
    public class Topico
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
