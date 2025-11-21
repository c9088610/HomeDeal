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
    public class PropertyService
    {
        private readonly IPropertyRepository _propertyRepository;
        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public List<Property> GetAll()
        {
            return _propertyRepository.GetList();
        }
    }
}