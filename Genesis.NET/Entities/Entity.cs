using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Genesis.Net.Entities
{
    public abstract class Entity
    {
        public override bool Equals(object obj)
        {
            if (GetType() != obj.GetType())
            {
                return false;
            }

            var otherEntity = (Entity)obj;
            foreach (var property in GetType().GetProperties())
            {
                var currentEntityPropertyValue = property.GetValue(this);
                var otherEntityPropertyValue = property.GetValue(otherEntity);

                if (typeof(Array).IsAssignableFrom(property.PropertyType) ||
                    typeof(IEnumerable<>).IsAssignableFrom(property.PropertyType))
                {
                    if (!SequenceEqual((IEnumerable<object>)currentEntityPropertyValue, (IEnumerable<object>)otherEntityPropertyValue))
                    {
                        return false;
                    }
                }
                else if (property.PropertyType.IsGenericType &&
                    typeof(IEnumerable<>).MakeGenericType(property.PropertyType.GetGenericArguments()).IsAssignableFrom(property.PropertyType))
                {
                    var currentEntityPropertyValueEnumerable = ((IEnumerable)currentEntityPropertyValue).Cast<object>();
                    var otherEntityPropertyValueEnumerable = ((IEnumerable)otherEntityPropertyValue).Cast<object>();
                    if (!Enumerable.SequenceEqual(currentEntityPropertyValueEnumerable, otherEntityPropertyValueEnumerable))
                    {
                        return false;
                    }
                }
                else if (currentEntityPropertyValue != null && !currentEntityPropertyValue.Equals(otherEntityPropertyValue))
                {
                    return false;
                }
            }

            return true;
        }

        private bool SequenceEqual(IEnumerable<object> sequence, IEnumerable<object> otherSequence)
        {
            if (sequence != null && otherSequence != null)
            {
                return Enumerable.SequenceEqual(sequence, otherSequence);
            }

            return sequence == null && otherSequence == null;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var prime = 17;
                var hashCode = 0;
                foreach (var propertyInfo in GetType().GetProperties())
                {
                    var propertyValue = propertyInfo.GetValue(this);
                    if (propertyValue != null)
                    {
                        hashCode = hashCode * prime + propertyValue.GetHashCode();
                    }
                }
                return hashCode;
            }
        }
    }
}