// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IError : IObject
    {
       int Code {get; set;}

       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

    }
}
