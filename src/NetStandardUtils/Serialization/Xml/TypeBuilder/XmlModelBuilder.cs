namespace NetStandardUtils.Serialization.Xml
{
    /// <summary>
    /// Provide a simple API surface that will allow to define the shape of entities,
    /// the relation between them and how they are mapped during XML serialization process.
    /// </summary>
    public sealed class XmlModelBuilder
    {
        internal XmlModelTypeInfo XmlModelInfo { get; }

        /// <summary>
        /// <summary>Initializes a new instance of the <see cref="XmlModelBuilder"/> class.</summary>
        /// </summary>
        public XmlModelBuilder()
        {
            XmlModelInfo = new XmlModelTypeInfo();
            HasKnownEntity<bool>();
            HasKnownEntity<byte>();
            HasKnownEntity<sbyte>();
            HasKnownEntity<char>();
            HasKnownEntity<decimal>();
            HasKnownEntity<double>();
            HasKnownEntity<float>();
            HasKnownEntity<int>();
            HasKnownEntity<uint>();
            HasKnownEntity<long>();
            HasKnownEntity<ulong>();
            HasKnownEntity<object>();
            HasKnownEntity<short>();
            HasKnownEntity<ushort>();
            HasKnownEntity<string>();
        }

        private XmlModelBuilder(XmlModelTypeInfo xmlModelTypeInfo)
        {
            XmlModelInfo = xmlModelTypeInfo;
        }

        /// <summary>
        /// Specify that an entity type belongs to the XML model.
        /// If the entity type is not already part of the model, it will be added to it.
        /// </summary>
        /// <typeparam name="TEntity">The entity type that belongs to XML model.</typeparam>
        /// <returns>An object that can be used to configure the entity type.</returns>
        public XmlEntityTypeBuilder<TEntity> HasKnownEntity<TEntity>()
        {
            XmlEntityTypeInfo xmlEntityTypeInfo = XmlModelInfo.GetOrCreateTypeInfo(typeof(TEntity));
            return new XmlEntityTypeBuilder<TEntity>(xmlEntityTypeInfo, XmlModelInfo, this);
        }

        /// <summary>
        /// Creates an independent copy of the current model.
        /// </summary>
        /// <returns>An independent copy of the current model.</returns>
        public XmlModelBuilder Copy()
        {
            XmlModelTypeInfo xmlModelTypeInfo = XmlModelInfo.Copy();
            return new XmlModelBuilder(xmlModelTypeInfo);
        }
    }
}