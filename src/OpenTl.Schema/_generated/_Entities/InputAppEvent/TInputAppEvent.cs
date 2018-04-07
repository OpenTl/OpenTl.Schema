// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x770656a8)]
	public sealed class TInputAppEvent : IInputAppEvent
	{
       [SerializationOrder(0)]
       public double Time {get; set;}

       /// <summary>Binary representation for the 'Type' property</summary>
       [SerializationOrder(1)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       [SerializationOrder(2)]
       public long Peer {get; set;}

       /// <summary>Binary representation for the 'Data' property</summary>
       [SerializationOrder(3)]
       public byte[] DataAsBinary { get => _DataAsBinary; set { _Data = Encoding.UTF8.GetString(value); _DataAsBinary = value; }}
       private byte[] _DataAsBinary;
       private string _Data;
       public string Data { get => _Data; set { DataAsBinary = Encoding.UTF8.GetBytes(value); _Data = value; }}

	}
}
