using System.Reflection;

namespace DotNetStandardUtils.Serialization.Xml
{
    internal class XmlPropertyTypeInfo
    {
        public PropertyInfo PropertyInfo { get; set; }
        public string XmlName { get; set; }
        public bool SerializeAsXmlAttribute { get; set; }
        public string AssociatedPropertyName { get; set; }
        public bool ShouldNotBeSerializedIfHasDefaultValue { get; set; }
    }
}