﻿using libreriaXAGFRRR.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace libreriaXAGFRRR.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Descripcion",
                        ISRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                    new Books()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Descripcion",
                        ISRead = true,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
