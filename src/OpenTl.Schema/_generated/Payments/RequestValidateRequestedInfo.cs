// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x770a8e74)]
    public sealed class RequestValidateRequestedInfo : IRequest<OpenTl.Schema.Payments.IValidatedRequestedInfo>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Save {get; set;}

       [SerializationOrder(2)]
       public int MsgId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPaymentRequestedInfo Info {get; set;}

    }
}
