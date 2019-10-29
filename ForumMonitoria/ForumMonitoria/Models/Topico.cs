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

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
