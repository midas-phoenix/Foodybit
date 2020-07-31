using Microsoft.AspNetCore.Identity;
using System;

namespace Foodybit.Core.Entities.RestaurantAggregate
{
    public class Staff: ApplicationUser
    {
        public int RestaurantId { get; private set; }
        public Restaurant Restaurant { get; private set; }
    }
}
