/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using Dapper;

namespace Dapper.Entities
{
    public class Program
    {
        public void Db(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ZTEX;Initial Catalog=Smat;Integrated Security=True"))
            {
                var employess = connection.Query<Employee>("SELECT * FROM Employee").ToList();
                foreach (Employee employee in employess)
                {
                    /* Console.WriteLine("ID: " + employee.ID);
                     Console.WriteLine("Name: " + employee.Name);
                     Console.WriteLine("Surname: " + employee.Surname);
                     Console.WriteLine("Phone: " + employee.Phone);
                     Console.WriteLine("CompanyId: " + employee.CompanyId);
                     Console.WriteLine("Type: " + employee.Type);
                     Console.WriteLine("Number: " + employee.Number);
                     Console.WriteLine("==========================");
                 }

             }
             Console.ReadLine();*/
              /*  }
            }
        }

    }
}*/
