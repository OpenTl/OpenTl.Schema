// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8cc0d131)]
	public class TMsgsAllInfo : IObject
	{
       [SerializationOrder(0)]
       public TVector<long> MsgIds {get; set;}

       [SerializationOrder(1)]
       public byte[] InfoAsBinary { get => _InfoAsBinary; set { _Info = Encoding.UTF8.GetString(value); _InfoAsBinary = value; }}
       private byte[] _InfoAsBinary;
       private string _Info;
       public string Info { get => _Info; set { InfoAsBinary = Encoding.UTF8.GetBytes(value); _Info = value; }}

	}
}
