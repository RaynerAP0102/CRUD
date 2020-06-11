using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Sistema.Models
{
    public class Estudiante
    {
        public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Edad { get; set; } 
        public string Genero { get; set; }
    }
}
