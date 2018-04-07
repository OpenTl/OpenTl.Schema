namespace OpenTl.Schema.Serialization.Attributes
{
    using System;

    internal class SerializationOrderAttribute : Attribute
    {
        internal int Order { get; }

        public SerializationOrderAttribute(int order)
        {
            Order = order;
        }
    }
}