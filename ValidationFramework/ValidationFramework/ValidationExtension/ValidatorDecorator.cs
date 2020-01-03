using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.ValidationExtension
{
    public class ValidatorDecorator : Validator
    {
        protected Validator validator; // error

    }
}
