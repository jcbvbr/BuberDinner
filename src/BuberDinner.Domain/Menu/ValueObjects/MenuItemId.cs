using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed partial class MenuItemId : ValueObject
    {
        private MenuItemId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static MenuItemId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }

}
