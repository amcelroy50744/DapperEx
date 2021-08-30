using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;

namespace Dapperdemo
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name, Price, CategoryID) VALUES(@name, @price, @categoryID);",
                new {name = name, price = price, categoryID = categoryID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
          return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }

    }
}
