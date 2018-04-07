// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa092a980)]
    public sealed class RequestGetPaymentReceipt : IRequest<OpenTl.Schema.Payments.IPaymentReceipt>
    {
       [SerializationOrder(0)]
       public int MsgId {get; set;}

    }
}
