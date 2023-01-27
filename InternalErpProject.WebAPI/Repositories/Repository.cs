using InternalErpProject.WebAPI.Data;
using InternalErpProject.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InternalErpProject.WebAPI.Repositories
{
    public class Repository : IRepository
    {

        private readonly ErpContext _context;
        public Repository(ErpContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        // Usuários
        public PersonModel[] GetAllPeople()
        {
            IQueryable<PersonModel> query = _context.People;

            query = query.AsNoTracking().OrderBy(p => p.IdPerson);

            return query.ToArray();
        }

        public PersonModel GetPersonByIdPerson(int idPerson)
        {
            IQueryable<PersonModel> query = _context.People;

            query = query.AsNoTracking()
                .OrderBy(p => p.IdPerson)
                .Where(person => person.IdPerson == idPerson);

            return query.FirstOrDefault();
        }
    }
}

