using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Inizialize (SistemaContext context)
        {
            context.Database.EnsureCreated();

            //Buscarn si exite
            if (context.Estudiante.Any()) 
            {
                return;
            }
            var estudiantes = new Estudiante[]
            {
                new Estudiante{Nombre="Orange", Edad="18", Genero="Femenino"}
            };

            foreach (Estudiante c in estudiantes)
            {
                context.Estudiante.Add(c);
            }
            context.SaveChanges();
        }
    }
}
