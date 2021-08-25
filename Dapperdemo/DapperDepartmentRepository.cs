using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace Dapperdemo
{
   public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        public DapperDepartmentRepository(IDbConnection connection) 
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments() 
        {
          return  _connection.Query<Department>("Select * From departmetns");
        }
    }
}
