using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountItemBonus;
        public DiscountedItem(IRentable rentable, double discount) : base(rentable)
        {
            this.DiscountItemBonus = discount;
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() * (1 - DiscountItemBonus / 100);
        }

        public override String Description
        {
            get
            {
                return base.Description + " now at " + DiscountItemBonus + "% off!";
            }
        }
    }
}
