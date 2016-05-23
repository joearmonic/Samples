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
    public class DealCardValidatorFactoryTests
    {
        [TestMethod()]
        public void CreateDealCardValidatorTest()
        {
            ValidatorFactory dealCardValFactory = new DealCardValidatorFactory();
            IValidator validator = dealCardValFactory.Create();
            Assert.IsInstanceOfType(validator, typeof(DealCardValidator));
        }
    }
}