using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudPrevention.Interfaces
{
    public abstract class ValidatorFactory
    {
        public abstract IValidator Create();
    }
}
