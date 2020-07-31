using Foodybit.Core.Entities.RestaurantAggregate;
using Microsoft.AspNetCore.Identity;
using System;

namespace Foodybit.Core.Entities.CustomerAggregate
{
    public class Customer : ApplicationUser
    {
        public Address address{ get; private set; }
        public Contact contact { get; private set; }
    }
}
