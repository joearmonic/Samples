//-----------------------------------------------------------------------------
// <copyright file="Order.cs" company="PayVision">
//     Copyright ® PayVision 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.DomainModel
{
    using System;

    public class Order
    {
        public int OrderId { get; set; }

        public int DealId { get; set; }

        public String Email { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        /// <summary>
        /// Gets or sets the zipCode. For US could be numeric, but when it comes to export the solution
        /// for other countries, that type will be a problem. Depending on this set operations must be validated
        /// for each country with a specific implementation.
        /// </summary>
        public String ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the credit card number. Credit card number are long enough to overflow numeric types. Thus
        /// string it's used. Must be complemented in set operations with regular expression to allow only numbers.
        /// </summary>
        public string CreditCardNumber { get; set; }
    }
}
