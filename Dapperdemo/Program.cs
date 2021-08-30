using System;
using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;



namespace Dapperdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);

            var departments = repo.GetAllDepartments();

            foreach (var department in departments) 
            {
                Console.WriteLine($"{department.DepartmentID} {department.Name}");
            }

            var repos = new DapperProductRepository(conn);

            var products = repos.GetAllProducts();

            foreach(var product in products) 
            {
                Console.WriteLine($"{product.CategoryID}{product.Name}");
            }


            
        }
    }
}
