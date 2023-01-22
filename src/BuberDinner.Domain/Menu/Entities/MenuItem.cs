using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities
{
    public sealed class MenuItem : Entity<MenuItemId>
    {
        private MenuItem(MenuItemId Id, string name, string description)
            : base(Id ?? MenuItemId.CreateUnique())
        {
            Name = name;
            Description = description;
        }

#pragma warning disable CS8618
        private MenuItem() { }
#pragma warning restore CS8618

        public string Name { get; private set; }
        public string Description { get; private set; }

        public static MenuItem Create(string name, string description)
            => new(MenuItemId.CreateUnique(), name, description);
    }
}
