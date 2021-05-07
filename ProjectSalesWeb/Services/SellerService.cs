using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSalesWeb.Models;

namespace ProjectSalesWeb.Services
{
    public class SellerService
    {
        private readonly ProjectSalesWebContext _context;
        public SellerService(ProjectSalesWebContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
