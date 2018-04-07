// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7d748d04)]
	public sealed class TDataJSON : IDataJSON
	{
       /// <summary>Binary representation for the 'Data' property</summary>
       [SerializationOrder(0)]
       public byte[] DataAsBinary { get => _DataAsBinary; set { _Data = Encoding.UTF8.GetString(value); _DataAsBinary = value; }}
       private byte[] _DataAsBinary;
       private string _Data;
       public string Data { get => _Data; set { DataAsBinary = Encoding.UTF8.GetBytes(value); _Data = value; }}

	}
}
