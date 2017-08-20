// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDhConfig : IObject
    {
       byte[] Random {get; set;}

    }
}
