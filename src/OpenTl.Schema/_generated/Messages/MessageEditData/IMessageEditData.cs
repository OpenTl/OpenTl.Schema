// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageEditData : IObject
    {
       BitArray Flags {get; set;}

       bool Caption {get; set;}

    }
}
