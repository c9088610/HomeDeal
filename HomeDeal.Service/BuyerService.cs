using HomeDeal.Core.Entities;
using HomeDeal.Core.Repositories;
using HomeDeal.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Service
{
    public class BuyerServic : IBuyerService
    {
        private readonly IBuyerRepository _buyerRepository;
        public BuyerServic(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }
        public List<Buyer> GetBuyers()
        {
            return _buyerRepository.GetAllBuyer();

        }
        public Buyer GetBuyer (int id)
        {
            return _buyerRepository.GetById(id);
        }

    }

}