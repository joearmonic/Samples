//-----------------------------------------------------------------------------
// <copyright file="AddressValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DomainModel;
    using Interfaces;

    public class AddressValidator : IValidator
    {
        private StateConverter stateConverter;

        private StreetConverter streetConverter;

        public AddressValidator()
        {
            stateConverter = new StateConverter();
            streetConverter = new StreetConverter();
        }

        public IEnumerable<Order> GetFraudulentOrders(IEnumerable<Order> orders)
        {
            List<Order> fraudulentOrders = new List<Order>();
            for (int i = 0; i < orders.Count(); i++)
            {
                Order pivotOrder = orders.Skip(i).First();
                string pivotAddress = NormalizeAddress(pivotOrder).ToUpper();
                IEnumerable<Order> comparedOrders = orders.Skip(i + 1).ToList();
                foreach (Order suspectedOrder in comparedOrders)
                {
                    string suspectedAddress = NormalizeAddress(suspectedOrder).ToUpper();
                    if (pivotAddress.Equals(suspectedAddress))
                    {
                        fraudulentOrders.Add(suspectedOrder);
                    }
                }
            }

            return fraudulentOrders;
        }

        private String NormalizeAddress(Order order)
        {
            string[] splittedStreet = order.Street.Split(' ');
            return string.Concat
                (
                    $"{splittedStreet[0]} {streetConverter.GetNameStreetType(splittedStreet[1])}",
                    $"{order.City} ",
                    $"{stateConverter.GetTextState(order.State)} ",
                    $"{order.ZipCode}"
                );
        }
    }
}