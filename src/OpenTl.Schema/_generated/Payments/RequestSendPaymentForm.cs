// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2b8879b3)]
    public class RequestSendPaymentForm : IRequest<Payments.IPaymentResult>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public string RequestedInfoId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public string ShippingOptionId {get; set;}

       [SerializationOrder(4)]
       public IInputPaymentCredentials Credentials {get; set;}

    }
}
