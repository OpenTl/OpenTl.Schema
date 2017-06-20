namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c20629f)]
	public class TInlineBotSwitchPM : IInlineBotSwitchPM
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

       [SerializationOrder(1)]
       public string StartParam {get; set;}

	}
}
