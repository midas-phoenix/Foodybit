using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities.MenuAggregate
{
    public class Offer: BaseEntity
    {
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        public double OfferPrice { get; private set; }
    }
}
