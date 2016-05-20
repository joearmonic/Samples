//-----------------------------------------------------------------------------
// <copyright file="MailValidator.cs" company="PayVision">
//     Copyright ® PayVision 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using DomainModel;
    using Interfaces;
    using System.Linq;

    public class MailValidator : IValidator
    {
        public IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders)
        {
            string pattern = "([0-9a-z])(@)";// Config!!
            Regex regEx = new Regex(pattern, RegexOptions.IgnoreCase);

            foreach (Order order in orders)
            {
                //IEnumerable<Order> comparedOrders = orders.Skip()
                bool IsFraudulent = regEx.Match(order.Email).Success;
            }

            //To capitalize to avoid case sensitive issue
            // and a regular expression pattern to solve A. and A+ cases.
            // Reg Exp patterns will be loaded by config.
            throw new NotImplementedException();
        }
    }
}
