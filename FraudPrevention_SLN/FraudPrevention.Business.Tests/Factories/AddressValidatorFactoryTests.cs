using Microsoft.VisualStudio.TestTools.UnitTesting;
using FraudPrevention.Business.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FraudPrevention.Interfaces;

namespace FraudPrevention.Business.Factories.Tests
{
    [TestClass()]
    public class AddressValidatorFactoryTests
    {
        [TestMethod()]
        public void CreateAddressValidatorTest()
        {
            ValidatorFactory addressValFactory = new AddressValidatorFactory();
            IValidator validator = addressValFactory.Create();
            Assert.IsInstanceOfType(validator, typeof(AddressValidator));
        }
    }
}