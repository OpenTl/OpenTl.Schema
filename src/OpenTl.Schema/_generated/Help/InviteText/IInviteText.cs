// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInviteText : IObject
    {
       byte[] MessageAsBinary {get; set;}
       string Message {get; set;}

    }
}
