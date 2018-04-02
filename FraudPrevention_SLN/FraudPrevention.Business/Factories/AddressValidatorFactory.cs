﻿//-----------------------------------------------------------------------------
// <copyright file="AddressValidatorFactory.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business.Factories
{
    using FraudPrevention.Interfaces;

    public class AddressValidatorFactory : ValidatorFactory
    {
        public override IValidator Create()
        {
            return new AddressValidator() as IValidator;
        }
    }
}
