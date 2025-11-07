using HomeDeal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Core.Service
{
    public interface IPropertyRepositories
    {

        public List<Property> GetList();
        public Property GetById(int id);


    }
}

