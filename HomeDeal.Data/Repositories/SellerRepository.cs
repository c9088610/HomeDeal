using HomeDeal.Core.Entities;
using HomeDeal.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class SellerRepository: ISellerRepository
    {
        private readonly DataContext _context;
        public SellerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Seller> GetList()
        {
            return _context.Seller;

        }
    }
}
