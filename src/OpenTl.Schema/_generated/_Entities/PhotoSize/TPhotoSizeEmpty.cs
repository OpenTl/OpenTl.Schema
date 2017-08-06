// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe17e23c)]
	public class TPhotoSizeEmpty : IPhotoSize, IEmpty
	{
       [SerializationOrder(0)]
       public byte[] YpeAsBinary { get => _YpeAsBinary; set { _Ype = Encoding.UTF8.GetString(value); _YpeAsBinary = value; }}
       private byte[] _YpeAsBinary;
       private string _Ype;
       public string Ype { get => _Ype; set { YpeAsBinary = Encoding.UTF8.GetBytes(value); _Ype = value; }}

	}
}
