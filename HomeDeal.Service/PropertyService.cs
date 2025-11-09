using HomeDeal.Core.Entities;
using HomeDeal.Core.Service;
using HomeDeal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Service
{
    public class PropertyServic : IPropertyService
    {
        private readonly IPropertyService _propertyservice;
        public PropertyServic(IPropertyService propertyservice)
        {
            _propertyservice = propertyservice;
        }
        public List<Buyer> GetAll()
        {
            return _propertyservice.GetAll();

        }
        public Buyer GetById(int id)
        {
            return _buyerRepository.GetById(id);
        }

    }

}