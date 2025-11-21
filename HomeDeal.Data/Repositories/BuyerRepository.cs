using HomeDeal.Core.Entities;
using HomeDeal.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class BuyerRepository: IBuyerRepository
    {
        private readonly DataContext _context;
        public BuyerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Buyer> GetList()
        {
            return _context.Buyer;

        }
    }
}
