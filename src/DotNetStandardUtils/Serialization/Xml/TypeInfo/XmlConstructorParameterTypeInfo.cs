namespace DotNetStandardUtils.Serialization.Xml
{
    internal class XmlConstructorParameterTypeInfo
    {
        public string AssociatedPropertyName { get; set; }
        public bool AssociatedPropertyValueIsSetBySerializer { get; set; }

        public XmlConstructorParameterTypeInfo Copy()
        {
            return new XmlConstructorParameterTypeInfo
            {
                AssociatedPropertyName = AssociatedPropertyName, 
                AssociatedPropertyValueIsSetBySerializer = AssociatedPropertyValueIsSetBySerializer
            };
        }
    }
}