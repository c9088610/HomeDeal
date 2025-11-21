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
    public class BuyerService
    {
        private readonly IBuyerRepository _buyerRepository;
        public BuyerService(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public List<Buyer> GetAll()
        {
            return _buyerRepository.GetList();
        }
        
    }
}

