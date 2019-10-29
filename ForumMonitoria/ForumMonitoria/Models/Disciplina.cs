using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumMonitoria.Models
{
    public class Disciplina
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public ICollection<Topico> Topicos { get; set; }
    }
}
