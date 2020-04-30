using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
