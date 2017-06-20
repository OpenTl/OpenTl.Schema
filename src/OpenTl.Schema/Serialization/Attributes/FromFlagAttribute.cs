using System;

namespace OpenTl.Schema.Serialization.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class FromFlagAttribute: Attribute
    {
        internal string PropertyName { get; }

        internal int Index { get; }

        public FromFlagAttribute(string propertyName, int index)
        {
            PropertyName = propertyName;
            Index = index;
        }
    }
}