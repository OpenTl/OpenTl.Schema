// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4fa417f2)]
	public sealed class TInputBotInlineResultGame : IInputBotInlineResult
	{
       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(0)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       /// <summary>Binary representation for the 'ShortName' property</summary>
       [SerializationOrder(1)]
       public byte[] ShortNameAsBinary { get => _ShortNameAsBinary; set { _ShortName = Encoding.UTF8.GetString(value); _ShortNameAsBinary = value; }}
       private byte[] _ShortNameAsBinary;
       private string _ShortName;
       public string ShortName { get => _ShortName; set { ShortNameAsBinary = Encoding.UTF8.GetBytes(value); _ShortName = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputBotInlineMessage SendMessage {get; set;}

	}
}
