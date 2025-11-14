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
        private readonly IPropertyRepositories _propertyRepository;
        public PropertyServic(IPropertyRepositories propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public List<Property> GetList()
        {
            return _propertyRepository.GetList();

        }
        public Property GetById(int id)
        {
            return _propertyRepository.GetById(id);
        }


    }
}