using ProjectSalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSalesWeb.Services
{
    public class DepartmentService
    {
        private readonly ProjectSalesWebContext _context;
        public DepartmentService(ProjectSalesWebContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
