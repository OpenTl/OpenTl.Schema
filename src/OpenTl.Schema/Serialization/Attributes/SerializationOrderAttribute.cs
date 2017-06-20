using System;

namespace OpenTl.Schema.Serialization.Attributes
{
    internal class SerializationOrderAttribute: Attribute
    {
        internal int Order { get; }

        public SerializationOrderAttribute(int order)
        {
            Order = order;
        }
    }
}