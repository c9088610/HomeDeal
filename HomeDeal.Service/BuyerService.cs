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
    public class BuyerService(IBuyerRepositories buyerRepository) : IBuyerService
    {
        private readonly IBuyerRepositories _buyerRepository = buyerRepository;

        public List<Buyer> GetList()
        {
            return _buyerRepository.GetList();
        }

        public Buyer GetById(int id)
        {
            return _buyerRepository.GetById(id);;
        }
    }

}