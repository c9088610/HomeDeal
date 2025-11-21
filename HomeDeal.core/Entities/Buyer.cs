using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Core.Entities
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double MaxBudget { get; set; }
        public DateTime RegistrationDate { get; set; }  //תאריך הרשמה 
    }
}
