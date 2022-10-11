using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Repository;
using PersonsWebApi.Infrastructure.Data;
using PersonsWebApi.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Infrastructure.Repository
{
    public class PhotoRepository : Repository<PersonPhoto>, IPhotoRepository
    {
        public PhotoRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task AddPhoto(string path, int personId)
        {
            var person = await _context.Persons.FindAsync(personId);
            person.PhotoPath = path;
            _context.Persons.Update(person);
            _context.SaveChanges();
        }

        public async Task DeletePhoto(int personId)
        {
            var person = await _context.Persons.FindAsync(personId);
            person.PhotoPath = String.Empty;
            _context.Persons.Update(person);
            _context.SaveChanges();
        }
    }
}
