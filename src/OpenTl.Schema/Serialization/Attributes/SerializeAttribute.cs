using System;

namespace OpenTl.Schema.Serialization.Attributes
{
    internal class SerializeAttribute: Attribute
    {
        internal uint Id { get; }

        public SerializeAttribute(uint id)
        {
            Id = id;
        }
    }
}