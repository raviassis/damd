﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumMonitoria.Models
{
    public class Mensagem
    {
        public int ID { get; set; }
        public string Texto { get; set; }
        public DateTime CriadoEm { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int TopicoID { get; set; }
        public Topico Topico { get; set; }
    }
}