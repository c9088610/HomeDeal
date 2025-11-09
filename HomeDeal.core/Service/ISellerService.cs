using HomeDeal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Core.Service
{
    public interface ISellerRepositories
    {

        public List<Seller> GetList();
        public Seller GetById(int id);


    }
}

