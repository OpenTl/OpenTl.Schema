// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInlineBotSwitchPM : IObject
    {
       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

       byte[] StartParamAsBinary {get; set;}
       string StartParam {get; set;}

    }
}
