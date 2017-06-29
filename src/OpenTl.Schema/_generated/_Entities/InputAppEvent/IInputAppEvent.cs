// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputAppEvent : IObject
    {
        double Ime {get; set;}

        string Type {get; set;}

        long Peer {get; set;}

        string Data {get; set;}

    }
}
