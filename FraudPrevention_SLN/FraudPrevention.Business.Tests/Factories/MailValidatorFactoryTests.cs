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
    public class MailValidatorFactoryTests
    {
        [TestMethod()]
        public void CreateMailValidatorTest()
        {
            ValidatorFactory  mailValFactory = new MailValidatorFactory();
            IValidator validator = mailValFactory.Create();
            Assert.IsInstanceOfType(validator, typeof(MailValidator));
        }
    }
}