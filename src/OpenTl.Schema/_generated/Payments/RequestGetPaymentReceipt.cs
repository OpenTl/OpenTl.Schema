namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa092a980)]
    public class RequestGetPaymentReceipt : IRequest<Payments.IPaymentReceipt>
    {
       [SerializationOrder(0)]
       public int MsgId {get; set;}

    }
}
