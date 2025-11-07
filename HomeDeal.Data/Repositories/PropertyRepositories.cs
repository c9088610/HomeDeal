using HomeDeal.C.Repositories;
using HomeDeal.Core.Service;
using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data.Repositories
{
    public class PropertyRepositories : IPropertyRepositories
    {
        private readonly DataContext _context;
        public PropertyRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Property> GetList()
        {
            return _context.Property.ToList();

        }
        public Property GetById(int id)
        {
            var p = _context.Property.ToList().Find(x => x.PropertyId == id);
            return p;
        }
    }
}
