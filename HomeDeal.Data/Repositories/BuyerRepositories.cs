using HomeDeal.C.Repositories;
using HomeDeal.Core.Service;
using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class BuyerRepositories :IBuyerRepositories
    {
        private readonly DataContext _context;
        public BuyerRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Buyer> GetList()
        {
            return _context.Buyer.ToList();

        }
        public Buyer GetById(int id)
        {
            var b = _context.Buyer.ToList().Find(x => x.BuyerId == id);
            return b;
        }
    }
}
