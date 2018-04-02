//-----------------------------------------------------------------------------
// <copyright file="MailValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
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
    using System.Configuration;
    public class MailValidator : IValidator
    {
        private string pattern;

        public MailValidator()
        {
            pattern = ConfigurationManager.AppSettings["mailPattern"];
        }
        public IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders)
        {
            List<Order> fraudulentOrders = new List<Order>();
            for (int i = 0; i < orders.Count(); i++)
            {
                Order pivotOrder = orders.Skip(i).First();
                string pivotMail = RemoveIgnorableChars(pivotOrder.Email).ToUpper();
                IEnumerable<Order> comparedOrders = orders.Skip(i+1).ToList();
                foreach (Order suspectedOrder in comparedOrders)
                {
                    string suspectedMail = RemoveIgnorableChars(suspectedOrder.Email).ToUpper();
                    if(pivotMail.Equals(suspectedMail))
                    {
                        fraudulentOrders.Add(suspectedOrder);
                    }
                }
            }

            return fraudulentOrders;
        }

        private String RemoveIgnorableChars(String baseMail)
        {
            String cleanedMail;
            Regex regEx = new Regex(this.pattern, RegexOptions.IgnoreCase);
            cleanedMail = Regex.Replace(baseMail, this.pattern, String.Empty);

            return cleanedMail;
        }
    }
}
