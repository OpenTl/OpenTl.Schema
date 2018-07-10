// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITermsOfService : IObject
    {
       BitArray Flags {get; set;}

       bool Popup {get; set;}

       OpenTl.Schema.IDataJSON Id {get; set;}

       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       int MinAgeConfirm {get; set;}

    }
}
