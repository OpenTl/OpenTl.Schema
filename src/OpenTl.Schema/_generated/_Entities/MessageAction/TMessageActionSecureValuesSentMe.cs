// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b287353)]
	public sealed class TMessageActionSecureValuesSentMe : IMessageAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValue> Values {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.ISecureCredentialsEncrypted Credentials {get; set;}

	}
}
