using System;
using System.Collections.Generic;
using System.Text;

namespace Dapperdemo
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
