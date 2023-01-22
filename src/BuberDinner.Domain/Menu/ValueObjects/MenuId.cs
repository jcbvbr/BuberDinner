﻿using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed partial class MenuId : ValueObject
    {
        private MenuId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static MenuId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
