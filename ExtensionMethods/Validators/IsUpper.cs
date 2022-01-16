using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ExtensionMethods.Validators
{
    public class IsUpper : ValidatorBase
    {
        public override bool isValid(string x)
        {
            return x.Any(w => char.IsUpper(w));
        }
    }
}
