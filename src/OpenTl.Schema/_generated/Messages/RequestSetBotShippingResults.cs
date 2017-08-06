// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe5f672fa)]
    public class RequestSetBotShippingResults : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] ErrorAsBinary { get => _ErrorAsBinary; set { _Error = Encoding.UTF8.GetString(value); _ErrorAsBinary = value; }}
       private byte[] _ErrorAsBinary;
       private string _Error;
       public string Error { get => _Error; set { ErrorAsBinary = Encoding.UTF8.GetBytes(value); _Error = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public TVector<IShippingOption> ShippingOptions {get; set;}

    }
}
