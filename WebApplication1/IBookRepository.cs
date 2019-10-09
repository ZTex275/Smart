using System.Collections.Generic;
using Dapper.Entities;

namespace Dapper.Repositories
{
    public interface IBookRepository
    {
        void Create(Employee book);
        void Delete(int id);
        Employee Get(int id);
        IEnumerable<Employee> GetAllBooks();
        void Update(Employee book);
    }
}