using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities.RestaurantAggregate
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; private set; }
        public Address Restaurantaddress { get; private set; }
        public Contact contact { get; private set; }
    }
}
