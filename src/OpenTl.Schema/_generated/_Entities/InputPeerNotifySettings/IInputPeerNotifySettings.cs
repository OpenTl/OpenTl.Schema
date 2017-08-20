// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputPeerNotifySettings : IObject
    {
       BitArray Flags {get; set;}

       bool ShowPreviews {get; set;}

       bool Silent {get; set;}

       int MuteUntil {get; set;}

       byte[] SoundAsBinary {get; set;}
       string Sound {get; set;}

    }
}
