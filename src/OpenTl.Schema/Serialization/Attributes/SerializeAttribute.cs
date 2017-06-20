using System;

namespace OpenTl.Schema.Serialization.Attributes
{
    internal class SerializeAttribute: Attribute
    {
        internal uint TypeId { get; }

        public SerializeAttribute(uint typeId)
        {
            TypeId = typeId;
        }
    }
}