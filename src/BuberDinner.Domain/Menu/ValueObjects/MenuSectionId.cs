using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class MenuSectionId : ValueObject
    {
        private MenuSectionId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; set; }

        public static MenuSectionId Create(Guid value) => new(value);

        public static MenuSectionId CreateUnique() => new(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
