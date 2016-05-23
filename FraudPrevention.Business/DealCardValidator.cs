//-----------------------------------------------------------------------------
// <copyright file="DealCardValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business
{
    using System.Collections.Generic;
    using System.Linq;
    using DomainModel;
    using Interfaces;

    public class DealCardValidator : IValidator
    {
        public IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders)
        {
            List<Order> suspectedOrders = new List<Order>();

            var ordersByDeal = orders.GroupBy(order => order.DealId);
            foreach (var ordersGrouped in ordersByDeal)
            {
                for (int i = 0; i < ordersGrouped.Count(); i++)
                {
                    Order pivotOrder = ordersGrouped.Skip(i).First();
                    List<Order> comparedList = new List<Order>() { pivotOrder };
                    suspectedOrders.AddRange(
                        ordersGrouped.Except(
                            comparedList, 
                            new CardEqualityComparer())
                        .ToList()
                    );
                }
            }

            return suspectedOrders;
        }
    }
}