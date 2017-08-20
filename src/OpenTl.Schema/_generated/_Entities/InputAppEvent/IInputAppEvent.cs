// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputAppEvent : IObject
    {
       double Time {get; set;}

       byte[] TypeAsBinary {get; set;}
       string Type {get; set;}

       long Peer {get; set;}

       byte[] DataAsBinary {get; set;}
       string Data {get; set;}

    }
}
