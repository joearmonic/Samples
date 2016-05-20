//-----------------------------------------------------------------------------
// <copyright file="AddressValidator.cs" company="PayVision">
//     Copyright ® PayVision 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business
{
    using System;
    using System.Collections.Generic;
    using DomainModel;
    using Interfaces;

    public class AddressValidator : IValidator
    {
        public IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders)
        {
            // It will use ToCapitalize in address fields
            // It will load from config the acronyms.
            throw new NotImplementedException();
        }
    }
}
