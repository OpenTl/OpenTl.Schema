// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITermsOfService : IObject
    {
       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

    }
}
