//-----------------------------------------------------------------------------
// <copyright file="StreetConverter.cs" company="EPapersoft">
//     Copyright ® EPapersoft 2016
// </copyright>
//-----------------------------------------------------------------------------
namespace FraudPrevention.DomainModel
{
    using System.Reflection;

    public class StreetConverter
    {
        private string Street = "St.";

        private string Road = "Rd.";

        public string GetNameStreetType(string streetType)
        {
            string streetTypeToReturn = string.Empty;
            FieldInfo[] nonPublicFields = this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic);
            foreach (var field in nonPublicFields)
            {
                if (field.GetValue(this).ToString().Equals(streetType))
                {
                    streetTypeToReturn = nameof(field);
                }
            }

            return streetTypeToReturn;
        }
    }
}