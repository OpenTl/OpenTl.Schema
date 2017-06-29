// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotCallbackAnswer : IObject
    {
        BitArray Flags {get; set;}

        bool Alert {get; set;}

        bool HasUrl {get; set;}

        string Message {get; set;}

        string Url {get; set;}

        int CacheTime {get; set;}

    }
}
