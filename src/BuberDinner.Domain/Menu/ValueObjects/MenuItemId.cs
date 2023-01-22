using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class MenuItemId : ValueObject
    {
        private MenuItemId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }

        public static MenuItemId Create(Guid value) => new(value);

        public static MenuItemId CreateUnique() => new(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }

}
