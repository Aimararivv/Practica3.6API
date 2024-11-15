using libreriaXAGFRRR.Data.Models;
using libreriaXAGFRRR.Data.ViewModels;
using System;

namespace libreriaXAGFRRR.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar una nueva editora en la BD
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name

            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
