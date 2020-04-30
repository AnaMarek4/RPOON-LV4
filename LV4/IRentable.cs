using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
