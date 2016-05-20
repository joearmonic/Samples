//-----------------------------------------------------------------------------
// <copyright file="IValidator.cs" company="PayVision">
//     Copyright ® PayVision 2016
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
