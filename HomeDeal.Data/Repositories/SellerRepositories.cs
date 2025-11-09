using HomeDeal.Core.Repositories;
using HomeDeal.Core.Service;
using HomeDeal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeDeal.Data.Repositories
{
    public class SellerRepositories : ISellerRepositories
    {
        private readonly DataContext _context;
        public SellerRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Seller> GetList()
        {
            return _context.Seller.ToList();

        }
        public Seller GetById(int id)
        {
            var s = _context.Seller.ToList().Find(x => x.SellerId == id);
            return s;
        }
    }
}
