//-----------------------------------------------------------------------------
// <copyright file="DealCardValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business
{
    using System.Collections.Generic;
    using DomainModel;

    internal class CardEqualityComparer : IEqualityComparer<Order>
    {
        public bool Equals(Order x, Order y)
        {
            return x.CreditCardNumber.Equals(y.CreditCardNumber);
        }

        public int GetHashCode(Order obj)
        {
            return obj.CreditCardNumber.GetHashCode() * 17;
        }
    }
}