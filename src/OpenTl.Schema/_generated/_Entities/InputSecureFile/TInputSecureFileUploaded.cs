// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3334b0f0)]
	public sealed class TInputSecureFileUploaded : IInputSecureFile
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Parts {get; set;}

       /// <summary>Binary representation for the 'Md5Checksum' property</summary>
       [SerializationOrder(2)]
       public byte[] Md5ChecksumAsBinary { get => _Md5ChecksumAsBinary; set { _Md5Checksum = Encoding.UTF8.GetString(value); _Md5ChecksumAsBinary = value; }}
       private byte[] _Md5ChecksumAsBinary;
       private string _Md5Checksum;
       public string Md5Checksum { get => _Md5Checksum; set { Md5ChecksumAsBinary = Encoding.UTF8.GetBytes(value); _Md5Checksum = value; }}

       [SerializationOrder(3)]
       public byte[] FileHash {get; set;}

       [SerializationOrder(4)]
       public byte[] Secret {get; set;}

	}
}
