using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Validations
{
    public static class StringValidations
    {
        public static bool QuantidateMaximaCaracters(string value, short maxLength)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
                return true;

            return false;
        }
    }
}
