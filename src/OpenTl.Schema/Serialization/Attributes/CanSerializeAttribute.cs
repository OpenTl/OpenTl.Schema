namespace OpenTl.Schema.Serialization.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    internal class CanSerializeAttribute : Attribute
    {
        internal string PropertyName { get; }

        internal int Index { get; }

        public CanSerializeAttribute(string propertyName, int index)
        {
            PropertyName = propertyName;
            Index = index;
        }
    }
}