// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputSingleMedia : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.IInputMedia Media {get; set;}

       long RandomId {get; set;}

       byte[] MessageAsBinary {get; set;}
       string Message {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

    }
}
