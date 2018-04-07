// ReSharper disable All

namespace OpenTl.Schema.Bots
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaa2769ed)]
    public sealed class RequestSendCustomRequest : IRequest<OpenTl.Schema.IDataJSON>
    {
       /// <summary>Binary representation for the 'CustomMethod' property</summary>
       [SerializationOrder(0)]
       public byte[] CustomMethodAsBinary { get => _CustomMethodAsBinary; set { _CustomMethod = Encoding.UTF8.GetString(value); _CustomMethodAsBinary = value; }}
       private byte[] _CustomMethodAsBinary;
       private string _CustomMethod;
       public string CustomMethod { get => _CustomMethod; set { CustomMethodAsBinary = Encoding.UTF8.GetBytes(value); _CustomMethod = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDataJSON Params {get; set;}

    }
}
