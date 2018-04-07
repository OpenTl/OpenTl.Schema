namespace OpenTl.Schema.Serialization.Attributes
{
    using System;

    internal class SerializeAttribute : Attribute
    {
        internal uint Id { get; }

        public SerializeAttribute()
        {
        }

        public SerializeAttribute(uint id)
        {
            Id = id;
        }
    }
}