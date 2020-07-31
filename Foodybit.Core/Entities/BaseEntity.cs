using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; protected set; }

        public DateTime DateCreated { get; private set; } = DateTime.Now;
    }
}
