using System.Collections.Generic;
using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Specs
{
    public class EntityComparer : IEqualityComparer<IEntity>
    {
        public bool Equals(IEntity x, IEntity y)
        {
            return x.EntityEquals(y).Item1;
        }

        public int GetHashCode(IEntity obj)
        {
            unchecked
            {
                var prime = 17;
                var hashCode = 0;
                foreach (var propertyInfo in GetType().GetProperties())
                {
                    var propertyValue = propertyInfo.GetValue(obj);
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
