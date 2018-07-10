// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe8a40bd9)]
	public sealed class TSecureValueErrorData : ISecureValueError
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ISecureValueType Type {get; set;}

       [SerializationOrder(1)]
       public byte[] DataHash {get; set;}

       /// <summary>Binary representation for the 'Field' property</summary>
       [SerializationOrder(2)]
       public byte[] FieldAsBinary { get => _FieldAsBinary; set { _Field = Encoding.UTF8.GetString(value); _FieldAsBinary = value; }}
       private byte[] _FieldAsBinary;
       private string _Field;
       public string Field { get => _Field; set { FieldAsBinary = Encoding.UTF8.GetBytes(value); _Field = value; }}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(3)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

	}
}
