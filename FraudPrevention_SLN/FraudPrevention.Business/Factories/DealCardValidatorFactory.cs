//-----------------------------------------------------------------------------
// <copyright file="DealCardValidatorFactory.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business.Factories
{
    using FraudPrevention.Interfaces;

    public class DealCardValidatorFactory : ValidatorFactory
    {
        public override IValidator Create()
        {
            return new DealCardValidator() as IValidator;
        }
    }
}
