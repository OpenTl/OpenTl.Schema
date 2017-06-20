namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x770a8e74)]
    public class RequestValidateRequestedInfo : IRequest<Payments.IValidatedRequestedInfo>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Save {get; set;}

       [SerializationOrder(2)]
       public int MsgId {get; set;}

       [SerializationOrder(3)]
       public IPaymentRequestedInfo Info {get; set;}

    }
}
