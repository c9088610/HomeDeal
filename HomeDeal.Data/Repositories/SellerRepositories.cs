using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class SellerRepositories
    {
        public readonly DataContext _context;
        public SellerRepositories(DataContext context)
        {
            _context = context;
        }
       
        public List<Seller> GetList()
        {
            return _context.Seller;
        }
    }
}
