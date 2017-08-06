// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9a734fa)]
	public class TPhotoCachedSize : IPhotoSize
	{
       [SerializationOrder(0)]
       public byte[] YpeAsBinary { get => _YpeAsBinary; set { _Ype = Encoding.UTF8.GetString(value); _YpeAsBinary = value; }}
       private byte[] _YpeAsBinary;
       private string _Ype;
       public string Ype { get => _Ype; set { YpeAsBinary = Encoding.UTF8.GetBytes(value); _Ype = value; }}

       [SerializationOrder(1)]
       public IFileLocation Location {get; set;}

       [SerializationOrder(2)]
       public int W {get; set;}

       [SerializationOrder(3)]
       public int H {get; set;}

       [SerializationOrder(4)]
       public byte[] Bytes {get; set;}

	}
}
