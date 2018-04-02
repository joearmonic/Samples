using Microsoft.VisualStudio.TestTools.UnitTesting;
using FraudPrevention.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FraudPrevention.DomainModel.Tests
{
    [TestClass()]
    public class StateConverterTests
    {
        [TestMethod()]
        public void GetTextStateTest()
        {
            StateConverter stateConverter = new StateConverter();
            var textState = stateConverter.GetTextState("IL");
            Assert.AreEqual("Illinois", textState);

            textState = stateConverter.GetTextState("CA");
            Assert.AreEqual("California", textState);

            textState = stateConverter.GetTextState("NY");
            Assert.AreEqual("New York", textState);
        }

        [TestMethod]
        public void GetTextStateNullArgTest()
        {
            StateConverter stateConverter = new StateConverter();
            try
            {
                var textState = stateConverter.GetTextState(null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentNullException));
            }
        }
    }
}