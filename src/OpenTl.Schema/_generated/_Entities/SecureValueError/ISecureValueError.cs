// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureValueError : IObject
    {
       OpenTl.Schema.ISecureValueType Type {get; set;}

       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

    }
}
