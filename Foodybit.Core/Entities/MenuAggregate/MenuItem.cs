using System;
using System.Collections.Generic;
using System.Text;

namespace Foodybit.Core.Entities.MenuAggregate
{
    public class MenuItem : BaseEntity
    {

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Ingredients { get; private set; }

        public double Price { get; private set; }

        public bool isActive { get; private set; } = true;

        public Category Category { get; private set; }

        public int CategoryId { get; private set; }

        public MenuItem()
        {

        }

        public MenuItem(string name, string description, string ingredients, double price, int categoryId)
        {
            Name = name; Description = description; Ingredients = ingredients; Price = price; CategoryId = categoryId;
        }
    }
}
