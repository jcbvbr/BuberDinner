﻿using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Host.ValueObjects
{
    public sealed class HostId : ValueObject
    {
        private HostId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static HostId Create(Guid value)
        {
            return new(value);
        }

        public static HostId Create(string hostId)
        {
            return new(new Guid(hostId));
        }

        public static HostId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
