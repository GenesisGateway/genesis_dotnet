using System.Reflection;
using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Specs.Validation
{
    abstract class describe_entity_property_validation
    {
        protected IEntity entity;
        protected string propertyName;
        protected PropertyInfo propertyInfo;
        protected string csePropertyName;
        protected PropertyInfo csePropertyInfo;

        public describe_entity_property_validation(IEntity entity, string propertyName, string csePropertyName = null)
        {
            this.entity = entity;
            this.propertyName = propertyName;
            propertyInfo = entity.GetType().GetProperty(this.propertyName);
            this.csePropertyName = csePropertyName;
            if (!string.IsNullOrEmpty(csePropertyName))
            {
                csePropertyInfo = entity.GetType().GetProperty(this.csePropertyName);
            }
        }
    }
}