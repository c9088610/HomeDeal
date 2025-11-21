using HomeDeal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeal.Data
{
    public class DataContext
    {
        public List<Property> Property { get; set; }
        public List<Seller> Seller { get; set; }
        public List<Buyer> Buyer { get; set; }

        public DataContext() {

            Property = new List<Property>
            {

                        new Property { PropertyId = 1000, Adress = "Raby Akiva 48,Beny-Brak", Price = 2700000, NumberOfRooms = 4.5, IsActiv = false },
                        new Property { PropertyId = 2000, Adress = "Raby yehuda hanasi 56,Petah-tikva", Price = 3500000, NumberOfRooms = 6.5, IsActiv = true },
                        new Property { PropertyId = 3000, Adress = "wayzman 14,Herzelya", Price = 4500000, NumberOfRooms = 8, IsActiv = true }
                    };



            Seller = new List<Seller> {
                        new Seller{SellerId=100,FullName="Ben natan",Phone="0586621145",Email="ben@gmail.com"},
                        new Seller{SellerId=200,FullName="David shir",Phone="0546665520",Email="david@gmail.com"},
                        new Seller{SellerId=300,FullName="yael ram",Phone="0521159963",Email="yaelram@gmail.com"}
                    };




            Buyer = new List<Buyer> {

                    new Buyer {BuyerId=1,FullName="Avrahm Levi",Phone="0527676152",Email="avram@gmail.com",MaxBudget=2500000,RegistrationDate=DateTime.Parse("05/10/2025")},
                        new Buyer {BuyerId=2,FullName="shay cohen",Phone="0527777715",Email="shay@gmail.com",MaxBudget=3000000,RegistrationDate=DateTime.Parse("01/07/2025")},
                        new Buyer {BuyerId=3,FullName="shira marom",Phone="0545483241",Email="shira@gmail.com",MaxBudget=2000000,RegistrationDate=DateTime.Parse("12/12/2025")},
                        new Buyer {BuyerId=4,FullName="sara danan",Phone="0579982154",Email="sara@gmail.com",MaxBudget=1900000,RegistrationDate=DateTime.Parse("16/08/2025")}
                    };

        }
    }
}
