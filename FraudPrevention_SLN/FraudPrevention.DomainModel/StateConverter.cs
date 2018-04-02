//-----------------------------------------------------------------------------
// <copyright file="AddressValidator.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.DomainModel
{
    using System;
    using System.Reflection;

    public class StateConverter
    {
        private string IL = "Illinois";

        private string CA = "California";

        private string NY = "New York";

        public string GetTextState(string stateType)
        {
            if (stateType == null)
            {
                throw new ArgumentNullException("stateType couldn't be null");
            }

            string stateToReturn = string.Empty;

            FieldInfo[] nonPublicFields = 
                this.GetType().GetFields(
                         BindingFlags.NonPublic |
                         BindingFlags.Instance
                );

            foreach (var field in nonPublicFields)
            {
                if (field.Name.Equals(stateType))
                {
                    stateToReturn = field.GetValue(this).ToString();
                    break;
                }
            }

            return stateToReturn;
        }
    }
}