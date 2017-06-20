namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x18cb9f78)]
	public class TInviteText : IInviteText
	{
       [SerializationOrder(0)]
       public string Message {get; set;}

	}
}
