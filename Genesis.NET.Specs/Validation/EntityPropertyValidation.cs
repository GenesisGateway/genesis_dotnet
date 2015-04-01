using System.Reflection;
using Genesis.Net.Entities;

namespace Genesis.Net.Specs.Validation
{
    abstract class describe_entity_property_validation
    {
        protected Entity entity;
        protected string propertyName;
        protected PropertyInfo propertyInfo;

        public describe_entity_property_validation(Entity entity, string propertyName)
        {
            this.entity = entity;
            this.propertyName = propertyName;
            propertyInfo = entity.GetType().GetProperty(this.propertyName);
        }
    }
}