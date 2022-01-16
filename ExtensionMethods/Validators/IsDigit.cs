using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethods.Validators
{
    public class IsDigit : ValidatorBase
    {
        public override bool isValid(string x)
        {
           return x.Any(x => char.IsDigit(x));
        }
    }
}
