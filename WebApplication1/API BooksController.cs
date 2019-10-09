using Dapper.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Dapper.Entities;

namespace WebApiTest.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IBookRepository _bookRepository = new BookRepository();
        // GET: api/Books
        // GET: api/Employee
        public async Task<IEnumerable<Employee>> Get()
        {
            return _bookRepository.GetAllBooks();
        }

        // GET: api/Books/5
        public Employee Get(int id)
        {
            return _bookRepository.Get(id);
        }

        // POST: api/Books
        public IHttpActionResult Post([FromBody]Employee book)
        {
            _bookRepository.Create(book);
            return Created(Request.RequestUri + book.ID.ToString(), book);
        }

        // PUT: api/Books/5
        public IHttpActionResult Put(int id, [FromBody]Employee book)
        {
            book.ID = id;
            _bookRepository.Update(book);
            return Ok();
        }

        // DELETE: api/Books/5
        public IHttpActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return Ok();
        }
    }
}