using System.Collections.Generic;
using System.Data;
using Dapper.Entities;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace Dapper.Repositories
{
        public class BookRepository : IBookRepository
        {
            private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DapperConnection"].ConnectionString;
            public IEnumerable<Employee> GetAllBooks()
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    return db.Query<Employee>("SELECT * FROM Employee");
                }
            }

            public Employee Get(int id)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    return db.Query<Employee>("SELECT * FROM Employee WHERE ID = @id", new { id }).FirstOrDefault();
                }
            }

            public void Create(Employee book)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                //var sqlQuery = "INSERT INTO Employee (Name, Author, PageCount) VALUES(@Name, @Author, @PageCount); SELECT CAST(SCOPE_IDENTITY() as int)";
                var sqlQuery = "INSERT INTO Employee *";
                int userId = db.Query<int>(sqlQuery, book).First();
                    book.ID = userId;
                }
            }

            public void Update(Employee book)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                   // var sqlQuery = "UPDATE Employee SET Name = @Name, Author = @Author, PageCount = @PageCount WHERE Id = @Id";
                    var sqlQuery = "UPDATE Employee SET Name = @Name WHERE ID = @Id";
                db.Execute(sqlQuery, book);
                }
            }

            public void Delete(int id)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    var sqlQuery = "DELETE FROM Employee WHERE ID = @id";
                    db.Execute(sqlQuery, new { id });
                }
            }
        }
    }