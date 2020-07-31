using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities.MenuAggregate
{
    public class MenuOffer: BaseEntity
    {
        public int MenuId { get; private set; }
        public MenuItem menuItem { get; private set; }
        public int OfferId { get; private set; }
        public Offer offer { get; private set; }

    }
}
