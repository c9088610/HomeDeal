using HomeDeal.Core.Entities;
using HomeDeal.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class PropertyRepository: IPropertyRepository
    {
        private readonly DataContext _context;
        public PropertyRepository(DataContext context)
        {
            _context = context;
        }
        public List<Property> GetList()
        {
            return _context.Property;
        }
    }
}
