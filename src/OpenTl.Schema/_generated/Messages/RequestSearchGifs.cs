// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbf9a776b)]
    public sealed class RequestSearchGifs : IRequest<OpenTl.Schema.Messages.IFoundGifs>
    {
       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(0)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(1)]
       public int Offset {get; set;}

    }
}
