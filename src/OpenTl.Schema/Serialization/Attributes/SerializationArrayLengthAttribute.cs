namespace OpenTl.Schema.Serialization.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    internal class SerializationArrayLengthAttribute : Attribute
    {
        internal int Length { get; }

        public SerializationArrayLengthAttribute(int length)
        {
            Length = length;
        }
    }
}