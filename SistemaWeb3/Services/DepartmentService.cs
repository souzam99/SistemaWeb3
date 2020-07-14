using System.Collections.Generic;
using System.Linq;
using SistemaWeb3.Models;

namespace SistemaWeb3.Services
{
    public class DepartmentService
    {
        private readonly SistemaWeb3Context _context;

        public DepartmentService(SistemaWeb3Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
