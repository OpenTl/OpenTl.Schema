// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x568a748)]
	public sealed class TKeyboardButtonSwitchInline : IKeyboardButton
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool SamePeer {get; set;}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(2)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

       /// <summary>Binary representation for the 'Query' property</summary>
       [SerializationOrder(3)]
       public byte[] QueryAsBinary { get => _QueryAsBinary; set { _Query = Encoding.UTF8.GetString(value); _QueryAsBinary = value; }}
       private byte[] _QueryAsBinary;
       private string _Query;
       public string Query { get => _Query; set { QueryAsBinary = Encoding.UTF8.GetBytes(value); _Query = value; }}

	}
}
