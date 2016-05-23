//-----------------------------------------------------------------------------
// <copyright file="IValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Interfaces
{
    using System.Collections.Generic;
    using DomainModel;
    public interface IValidator
    {
        IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders);
    }
}
