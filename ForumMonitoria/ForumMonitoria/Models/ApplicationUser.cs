using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForumMonitoria.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Topico> Topicos { get; set; }
    }
}
