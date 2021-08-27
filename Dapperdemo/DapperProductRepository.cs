using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;

namespace Dapperdemo
{
    public class DapperProductRepository 
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
          return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }

    }
}
