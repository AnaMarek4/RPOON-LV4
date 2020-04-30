using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV4
{
    class EmailValidator : IEmailValidatorService
    {
        private bool ContainsMonkeySymbol(String candidate)
        {
            return candidate.Contains('@');
        }

        private bool EndsWithDomain(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }

        public bool IsValidAddress(string candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return ContainsMonkeySymbol(candidate) && EndsWithDomain(candidate);
        }
    }
}
