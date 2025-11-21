using HomeDeal.Core.Entities;
using HomeDeal.Core.Repository;
using HomeDeal.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Service
{
    public class SellerService
    {
        private readonly ISellerRepository _sellerRepository;
        public SellerService(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public List<Seller> GetAll()
        {
            return _sellerRepository.GetList();
        }
    }
}
