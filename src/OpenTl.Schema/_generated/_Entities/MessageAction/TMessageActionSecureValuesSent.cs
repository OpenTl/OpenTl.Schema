// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd95c6154)]
	public sealed class TMessageActionSecureValuesSent : IMessageAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueType> Types {get; set;}

	}
}
