using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Xml.Serialization
{
    internal class XmlEntityTypeInfo
    {
        public XmlEntityTypeInfo()
        {
            PropertiesTypeInfo = new Dictionary<string, XmlPropertyTypeInfo>();
            ConstructorParametersTypeInfo = new Dictionary<int, XmlConstructorParameterTypeInfo>();
        }

        public Type EntityType { get; set; }
        public string XmlName { get; set; }
        public bool SerializeAsXmlAttribute { get; set; }
        public IDictionary<string, XmlPropertyTypeInfo> PropertiesTypeInfo { get; }
        public IDictionary<int, XmlConstructorParameterTypeInfo> ConstructorParametersTypeInfo { get; }

        public XmlPropertyTypeInfo GetOrCreatePropertyTypeInfo(string propertyName, PropertyInfo propertyInfo)
        {
            if (!PropertiesTypeInfo.TryGetValue(propertyName, out XmlPropertyTypeInfo xmlPropertyTypeInfo))
            {
                xmlPropertyTypeInfo = new XmlPropertyTypeInfo();
                xmlPropertyTypeInfo.AssociatedPropertyName = propertyName;
                xmlPropertyTypeInfo.PropertyInfo = propertyInfo;
                PropertiesTypeInfo.Add(propertyName,xmlPropertyTypeInfo);
            }
            return xmlPropertyTypeInfo;
        }

        public XmlConstructorParameterTypeInfo GetOrCreateConstructorParameterTypeInfo(int constructorParameterIndex)
        {
            if (!ConstructorParametersTypeInfo.TryGetValue(constructorParameterIndex, out XmlConstructorParameterTypeInfo xmlConstructorParameterTypeInfo))
            {
                xmlConstructorParameterTypeInfo = new XmlConstructorParameterTypeInfo();
                ConstructorParametersTypeInfo.Add(constructorParameterIndex, xmlConstructorParameterTypeInfo);
            }
            return xmlConstructorParameterTypeInfo;
        }

        public XmlEntityTypeInfo Copy()
        {
            XmlEntityTypeInfo xmlEntityTypeInfo = new XmlEntityTypeInfo();
            xmlEntityTypeInfo.EntityType = EntityType;
            xmlEntityTypeInfo.XmlName = XmlName;
            xmlEntityTypeInfo.SerializeAsXmlAttribute = SerializeAsXmlAttribute;

            foreach (var propertyTypeInfoByName in PropertiesTypeInfo)
            {
                xmlEntityTypeInfo.PropertiesTypeInfo.Add(propertyTypeInfoByName.Key, propertyTypeInfoByName.Value.Copy());
            }

            foreach (var constructorParameterTypeInfoByPosition in ConstructorParametersTypeInfo)
            {
                xmlEntityTypeInfo.ConstructorParametersTypeInfo.Add(constructorParameterTypeInfoByPosition.Key, constructorParameterTypeInfoByPosition.Value.Copy());
            }
            return xmlEntityTypeInfo;
        }
    }
}