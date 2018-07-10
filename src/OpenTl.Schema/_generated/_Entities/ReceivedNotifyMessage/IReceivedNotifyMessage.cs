// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IReceivedNotifyMessage : IObject
    {
       int Id {get; set;}

       int Flags {get; set;}

    }
}
