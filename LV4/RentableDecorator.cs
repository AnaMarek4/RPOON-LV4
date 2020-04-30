using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class RentableDecorator : IRentable
    {
        private IRentable rentable;
        public RentableDecorator(IRentable rentable)
        {
            this.rentable = rentable;
        }

        public virtual double CalculatePrice()
        {
            return rentable.CalculatePrice();
        }

        public virtual String Description
        {
            get
            {
                return rentable.Description;
            }
        }
    }
}
