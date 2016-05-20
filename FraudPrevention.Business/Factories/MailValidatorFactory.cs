//-----------------------------------------------------------------------------
// <copyright file="MailValidatorFactory.cs" company="PayVision">
//     Copyright ® PayVision 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.Business.Factories
{
    using FraudPrevention.Interfaces;

    public class MailValidatorFactory : ValidatorFactory
    {
        public override IValidator Create()
        {
            return new MailValidator() as IValidator;
        }
    }
}
