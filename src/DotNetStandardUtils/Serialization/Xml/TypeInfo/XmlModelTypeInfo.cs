using System;
using System.Collections.Generic;
using System.Reflection;

namespace DotNetStandardUtils.Serialization.Xml
{
    internal class XmlModelTypeInfo
    {
        public XmlModelTypeInfo()
        {
            EntitiesInfoKeyedByType = new Dictionary<Type, XmlEntityTypeInfo>();
            SerializationTypesKeyedByName = new Dictionary<string, Type>();
        }
        public IDictionary<Type, XmlEntityTypeInfo> EntitiesInfoKeyedByType { get; }
        public IDictionary<string, Type> SerializationTypesKeyedByName { get; }

        public XmlEntityTypeInfo GetOrCreateTypeInfo(Type entityType)
        {
            if (!EntitiesInfoKeyedByType.TryGetValue(entityType, out XmlEntityTypeInfo xmlEntityTypeInfo))
            {
                xmlEntityTypeInfo = new XmlEntityTypeInfo();
                xmlEntityTypeInfo.EntityType = entityType;
                EntitiesInfoKeyedByType.Add(entityType, xmlEntityTypeInfo);
            }
            return xmlEntityTypeInfo;
        }

        public XmlPropertyTypeInfo GetOrCreatePropertyTypeInfo(Type entityType, string propertyName, PropertyInfo propertyInfo)
        {
            XmlEntityTypeInfo xmlEntityTypeInfo = GetOrCreateTypeInfo(entityType);
            return xmlEntityTypeInfo.GetOrCreatePropertyTypeInfo(propertyName, propertyInfo);
        }

        public XmlConstructorParameterTypeInfo GetOrCreateConstructorArgumentTypeInfo(Type entityType, int constructorParameterIndex)
        {
            XmlEntityTypeInfo xmlEntityTypeInfo = GetOrCreateTypeInfo(entityType);
            return xmlEntityTypeInfo.GetOrCreateConstructorParameterTypeInfo(constructorParameterIndex);
        }
    }
}