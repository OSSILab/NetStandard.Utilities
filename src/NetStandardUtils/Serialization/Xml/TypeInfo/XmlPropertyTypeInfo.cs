using System.Reflection;

namespace NetStandardUtils.Serialization.Xml
{
    internal class XmlPropertyTypeInfo
    {
        public PropertyInfo PropertyInfo { get; set; }
        public string XmlName { get; set; }
        public bool SerializeAsXmlAttribute { get; set; }
        public string AssociatedPropertyName { get; set; }
        public bool ShouldNotBeSerializedIfHasDefaultValue { get; set; }

        public XmlPropertyTypeInfo Copy()
        {
            return new XmlPropertyTypeInfo
            {
                PropertyInfo = PropertyInfo,
                XmlName = XmlName,
                SerializeAsXmlAttribute = SerializeAsXmlAttribute,
                AssociatedPropertyName = AssociatedPropertyName,
                ShouldNotBeSerializedIfHasDefaultValue = ShouldNotBeSerializedIfHasDefaultValue
            };
        }
    }
}