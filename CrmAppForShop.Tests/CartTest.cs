using ClassLibrary1.Model;
using CRMBLL.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CrmAppForShop.Tests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void CartTests()
        {
            //arrange

            var customer = new Customer()
            { 
                CustomerId=1,
                Name = "Customer1"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "Product1",
                Price = 40,
                Count = 4
            };
            var product2 = new Product()
            {
                ProductId=2, 
                Name = "Product2",
                Price = 80,
                Count = 12
            };

            //act

            var cart = new Cart(customer);
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var expectedResult = new List<Product>()
            {
                product1,product1,product2
            };
            var cartResult = cart.GetAll();

            //assert

            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
            

        }
    }
}
