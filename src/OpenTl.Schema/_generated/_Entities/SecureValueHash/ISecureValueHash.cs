// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureValueHash : IObject
    {
       OpenTl.Schema.ISecureValueType Type {get; set;}

       byte[] Hash {get; set;}

    }
}
