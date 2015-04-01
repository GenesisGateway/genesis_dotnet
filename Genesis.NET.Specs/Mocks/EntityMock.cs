using System;
using System.Linq;
using Genesis.Net.Entities;

namespace Genesis.Net.Specs.Mocks
{
    class EntityMock<T> where T : Entity
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
