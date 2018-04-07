// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77bfb61b)]
	public sealed class TPhotoSize : IPhotoSize
	{
       /// <summary>Binary representation for the 'Type' property</summary>
       [SerializationOrder(0)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.IFileLocation Location {get; set;}

       [SerializationOrder(2)]
       public int W {get; set;}

       [SerializationOrder(3)]
       public int H {get; set;}

       [SerializationOrder(4)]
       public int Size {get; set;}

	}
}
