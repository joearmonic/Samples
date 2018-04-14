using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class OptionModel
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public int NameId { get; set; }

        public  DescriptorModel NameDescriptor { get; set; }

        public int ParameterId { get; set; }

        public  ParameterModel Parameter { get; set; }
    }
}