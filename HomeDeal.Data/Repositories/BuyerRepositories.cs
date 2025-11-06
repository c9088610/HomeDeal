using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class BuyerRepositories
    {
        public readonly DataContext _context;
        public BuyerRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Buyer> GetList()
        {
            return _context.Buyer;

        }
    }
}
