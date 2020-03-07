namespace DotNetStandardUtils.Serialization.Xml
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for working with specific
    /// kinds of xml model builder instances.
    /// </summary>
    public static class XmlModelBuilderExtensions
    {
        /// <summary>
        /// Specifies that the <see cref="XmlSerializer"/> should not serialize the property if the value of it is <c>default</c>
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity that belongs to XML model.</typeparam>
        /// <typeparam name="TProperty">The type of the property that belongs to <typeparamref name="TEntity"/> entity in the XML model.</typeparam>
        /// <param name="xmlPropertyTypeBuilder">The property builder to be configured.</param>
        /// <returns><see cref="XmlPropertyTypeBuilder{TEntity,TProperty}"/>An object that can be used to configure the property.</returns>
        public static XmlPropertyTypeBuilder<TEntity, TProperty> ShouldNotBeSerializedIfHasDefaultValue<TEntity, TProperty>(this XmlPropertyTypeBuilder<TEntity, TProperty> xmlPropertyTypeBuilder) where TProperty : struct
        {
            xmlPropertyTypeBuilder.ShouldNotBeSerializedIfValueEqualsWithDefaultValue = true;
            return xmlPropertyTypeBuilder;
        }

        /// <summary>
        /// Specifies that the <see cref="XmlSerializer"/> should serialize the property even if the value of it is <c>default</c>
        /// This is the default behavior.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity that belongs to XML model.</typeparam>
        /// <typeparam name="TProperty">The type of the property that belongs to <typeparamref name="TEntity"/> entity in the XML model.</typeparam>
        /// <param name="xmlPropertyTypeBuilder">The property builder to be configured.</param>
        /// <returns><see cref="XmlPropertyTypeBuilder{TEntity,TProperty}"/>An object that can be used to configure the property.</returns>
        public static XmlPropertyTypeBuilder<TEntity, TProperty> ShouldBeSerializedIfHasDefaultValue<TEntity, TProperty>(this XmlPropertyTypeBuilder<TEntity, TProperty> xmlPropertyTypeBuilder) where TProperty : struct
        {
            xmlPropertyTypeBuilder.ShouldNotBeSerializedIfValueEqualsWithDefaultValue = false;
            return xmlPropertyTypeBuilder;
        }
    }
}