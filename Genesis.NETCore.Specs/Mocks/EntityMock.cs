using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Specs.Mocks
{
    public class EntityMock<T> where T : IEntity
    {
        public readonly T Instance;
        public readonly string Xml;

        public EntityMock(T instance, string xml)
        {
            Instance = instance;
            Xml = xml;
        }
    }
}
