using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class PropertyRepositories
    {
        public readonly DataContext _context;
        public PropertyRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Property> GetList()
        {
            return _context.Property;
        }
    }
}
