// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputBotInlineMessageID : IObject
    {
       int DcId {get; set;}

       long Id {get; set;}

       long AccessHash {get; set;}

    }
}
