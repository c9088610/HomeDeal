using HomeDeal.Controllers;
using HomeDeal.entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class SellerControllerTests
    {
        [Fact]
        public void GetAll_ReturnOk()

        {
            //Arange-      אירגון_הנתונים_הנדרשים;

            //var controller=new SellerController();

            //Act-  הפעלת_הפונקציה
            var controller =new SellerController();
            var reazel = controller.Get();




            //Assert-   הכרזה_מה_אני_מצפה_שיחזיר
            Assert.IsType<List<Seller>>(reazel);

        }
        [Fact]
        public void GetId_ReturnOk()

        {
            //Arange-      אירגון_הנתונים_הנדרשים;

            var id = 100;

            //Act-  הפעלת_הפונקציה
            var controller = new SellerController();
            var reazel = controller.Get(id);




            //Assert-   הכרזה_מה_אני_מצפה_שיחזיר
            Assert.IsType<OkObjectResult> (reazel);

        }
        [Fact]
        public void GetId_ReturnNotFound()

        {
            //Arange-      אירגון_הנתונים_הנדרשים;

            var id = 200;

            //Act-  הפעלת_הפונקציה
            var controller = new SellerController();
            var reazel = controller.Get(id);




            //Assert-   הכרזה_מה_אני_מצפה_שיחזיר
            Assert.IsType<NotFoundObjectResult>(reazel);

        }
       
    }
}
