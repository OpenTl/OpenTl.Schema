// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2b8879b3)]
    public sealed class RequestSendPaymentForm : IRequest<OpenTl.Schema.Payments.IPaymentResult>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       /// <summary>Binary representation for the 'RequestedInfoId' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] RequestedInfoIdAsBinary { get => _RequestedInfoIdAsBinary; set { _RequestedInfoId = Encoding.UTF8.GetString(value); _RequestedInfoIdAsBinary = value; }}
       private byte[] _RequestedInfoIdAsBinary;
       private string _RequestedInfoId;
       public string RequestedInfoId { get => _RequestedInfoId; set { RequestedInfoIdAsBinary = Encoding.UTF8.GetBytes(value); _RequestedInfoId = value; }}

       /// <summary>Binary representation for the 'ShippingOptionId' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] ShippingOptionIdAsBinary { get => _ShippingOptionIdAsBinary; set { _ShippingOptionId = Encoding.UTF8.GetString(value); _ShippingOptionIdAsBinary = value; }}
       private byte[] _ShippingOptionIdAsBinary;
       private string _ShippingOptionId;
       public string ShippingOptionId { get => _ShippingOptionId; set { ShippingOptionIdAsBinary = Encoding.UTF8.GetBytes(value); _ShippingOptionId = value; }}

       [SerializationOrder(4)]
       public OpenTl.Schema.IInputPaymentCredentials Credentials {get; set;}

    }
}
