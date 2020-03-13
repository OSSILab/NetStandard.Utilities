namespace NetStandardUtils.Serialization.Xml
{
    /// <summary>
    /// Provides a simple API for configuring the constructor of the entity type in the XML model.
    /// A specific entity can be deserialized using an user defined constructor.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity that belongs to XML model.</typeparam>
    public sealed class XmlConstructorTypeBuilder<TEntity>
    {
        private readonly XmlEntityTypeInfo _xmlEntityTypeInfo;
        private readonly XmlModelBuilder _xmlModelTypeBuilder;
        private readonly XmlModelTypeInfo _xmlModelTypeInfo;

        internal XmlConstructorTypeBuilder(XmlEntityTypeInfo xmlEntityTypeInfo, XmlModelTypeInfo xmlModelTypeInfo, XmlModelBuilder xmlModelTypeBuilder)
        {
            _xmlEntityTypeInfo = xmlEntityTypeInfo;
            _xmlModelTypeBuilder = xmlModelTypeBuilder;
            _xmlModelTypeInfo = xmlModelTypeInfo;
        }

        /// <summary>
        /// Excludes the constructor from XML model.
        /// </summary>
        /// <returns><see cref="XmlModelBuilder"/></returns>
        public XmlModelBuilder Ignore()
        {
            _xmlEntityTypeInfo.ConstructorParametersTypeInfo.Clear();
            return _xmlModelTypeBuilder;
        }


        /// <summary>
        /// Returns an object that can be used to configure the constructor parameter of the entity type.
        /// A specific entity can be deserialized using an user defined constructor.
        /// If the specified constructor parameter is not already part of the model, it will be added. 
        /// </summary>
        /// <param name="parameterIndex"></param>
        /// <returns><see cref="XmlConstructorParameterTypeBuilder{TEntity}"/></returns>
        public XmlConstructorParameterTypeBuilder<TEntity> Parameter(int parameterIndex)
        {
            XmlConstructorParameterTypeInfo constructorParameterTypeInfo = _xmlEntityTypeInfo.GetOrCreateConstructorParameterTypeInfo(parameterIndex);
            return new XmlConstructorParameterTypeBuilder<TEntity>(_xmlEntityTypeInfo, constructorParameterTypeInfo, _xmlModelTypeInfo, _xmlModelTypeBuilder);
        }
    }
}