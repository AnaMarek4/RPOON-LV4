using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
