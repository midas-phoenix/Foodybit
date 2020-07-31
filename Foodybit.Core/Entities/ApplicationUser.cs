using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; private set; }
        public DateTimeOffset DateCreated { get; private set; } = DateTimeOffset.Now;
    }
}
