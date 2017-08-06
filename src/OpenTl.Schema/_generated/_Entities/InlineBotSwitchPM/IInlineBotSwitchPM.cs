// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInlineBotSwitchPM : IObject
    {
       byte[] ExtAsBinary {get; set;}
       string Ext {get; set;}

       byte[] StartParamAsBinary {get; set;}
       string StartParam {get; set;}

    }
}
