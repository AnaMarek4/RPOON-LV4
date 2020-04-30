using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
