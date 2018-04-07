// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6df7378)]
    public sealed class RequestStartBot : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Bot {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       public long RandomId {get; set;}

       /// <summary>Binary representation for the 'StartParam' property</summary>
       [SerializationOrder(3)]
       public byte[] StartParamAsBinary { get => _StartParamAsBinary; set { _StartParam = Encoding.UTF8.GetString(value); _StartParamAsBinary = value; }}
       private byte[] _StartParamAsBinary;
       private string _StartParam;
       public string StartParam { get => _StartParam; set { StartParamAsBinary = Encoding.UTF8.GetBytes(value); _StartParam = value; }}

    }
}
