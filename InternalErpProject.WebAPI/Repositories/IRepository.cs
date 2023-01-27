using InternalErpProject.WebAPI.Models;
using System;
using System.Threading.Tasks;

namespace InternalErpProject.WebAPI.Repositories
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        // Pessoas
        PersonModel[] GetAllPeople();
        PersonModel GetPersonByIdPerson(int idPerson);
    }
}
