// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x73665bc2)]
    public sealed class RequestGetSecureValue : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ISecureValue>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueType> Types {get; set;}

    }
}
