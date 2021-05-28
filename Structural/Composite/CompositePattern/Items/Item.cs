using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Items
{
    public abstract class Item
    {
        public Guid Id { get; private set; }
        public string ItemName { get; private set; }
        public IList<Item> Childrens { get; private set; }

        protected Item(string itemName)
        {
            Id = Guid.NewGuid();
            ItemName = itemName;
            Childrens = new List<Item>();
        }

        public void AddChildren(Item item)
            => Childrens.Add(item);

        public void RemoveChildren(Item item)
            => Childrens.Remove(item);

        public Item GetChildrenAt(int position)
        {
            if (Childrens.ElementAtOrDefault(position) != null)
                return Childrens[position];

            return null;
        }

        public void Display()
        {
            Console.WriteLine("\n\n-------------------");
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("\nId: " + Id.ToString());
            Console.WriteLine("Item Name: " + ItemName);

            foreach (var child in Childrens)
                child.Display();
        }
        
    }
}
