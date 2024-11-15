using libreriaXAGFRRR.Data.Models;
using libreriaXAGFRRR.Data.ViewModels;
using System;

namespace libreriaXAGFRRR.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo autor en la BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
      
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
