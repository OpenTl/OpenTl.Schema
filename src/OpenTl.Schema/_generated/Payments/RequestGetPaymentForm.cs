// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x99f09745)]
    public class RequestGetPaymentForm : IRequest<Payments.IPaymentForm>
    {
       [SerializationOrder(0)]
       public int MsgId {get; set;}

    }
}
