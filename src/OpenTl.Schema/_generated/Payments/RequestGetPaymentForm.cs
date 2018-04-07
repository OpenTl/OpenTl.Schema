// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x99f09745)]
    public sealed class RequestGetPaymentForm : IRequest<OpenTl.Schema.Payments.IPaymentForm>
    {
       [SerializationOrder(0)]
       public int MsgId {get; set;}

    }
}
