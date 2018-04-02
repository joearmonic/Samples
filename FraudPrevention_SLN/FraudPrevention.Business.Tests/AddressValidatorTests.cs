using Microsoft.VisualStudio.TestTools.UnitTesting;
using FraudPrevention.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FraudPrevention.Interfaces;
using FraudPrevention.DomainModel;

namespace FraudPrevention.Business.Tests
{
    [TestClass()]
    public class AddressValidatorTests
    {
        [TestMethod()]
        public void GetFraudulentOrdersByAddressTest()
        {
            List<Order> orders = new List<Order>()
            {
                new Order()
                {
                    OrderId = 1,
                    DealId = 1,
                    City = "New york",
                    CreditCardNumber = "XXX1",
                    Email = "jalamo@mail.com",
                    State = "NY",
                    Street = "Broadway St.",
                    ZipCode = "XXXXX"
                },
                new Order()
                {
                    OrderId = 2,
                    DealId = 1,
                    City = "New york",
                    CreditCardNumber = "XXX1",
                    Email = "jalamo@mail.com",
                    State = "NY",
                    Street = "Broadway Street",
                    ZipCode = "XXXXX"
                }
            };

            AddressValidator validator = new AddressValidator();
            IEnumerable<Order> fraudulents = validator.GetFraudulentOrders(orders);

            Assert.IsTrue(fraudulents.Count() > 0);
        }

        [TestMethod()]
        public void GetNoneFraudulentOrdersByAddressTest()
        {
            List<Order> orders = new List<Order>()
            {
                new Order()
                {
                    OrderId = 1,
                    DealId = 1,
                    City = "New york",
                    CreditCardNumber = "XXX1",
                    Email = "jalamo@mail.com",
                    State = "NY",
                    Street = "Broadway St.",
                    ZipCode = "XXXXX"
                },
                new Order()
                {
                    OrderId = 2,
                    DealId = 1,
                    City = "New york",
                    CreditCardNumber = "XXX1",
                    Email = "jalamo@mail.com",
                    State = "NY",
                    Street = "Broadway St.",
                    ZipCode = "XXXX1"
                }
            };

            AddressValidator validator = new AddressValidator();
            IEnumerable<Order> fraudulents = validator.GetFraudulentOrders(orders);

            Assert.IsTrue(fraudulents.Count() == 0);
        }

    }
}