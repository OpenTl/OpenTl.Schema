// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc331e80a)]
	public sealed class TInputGameShortName : IInputGame
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser BotId {get; set;}

       /// <summary>Binary representation for the 'ShortName' property</summary>
       [SerializationOrder(1)]
       public byte[] ShortNameAsBinary { get => _ShortNameAsBinary; set { _ShortName = Encoding.UTF8.GetString(value); _ShortNameAsBinary = value; }}
       private byte[] _ShortNameAsBinary;
       private string _ShortName;
       public string ShortName { get => _ShortName; set { ShortNameAsBinary = Encoding.UTF8.GetBytes(value); _ShortName = value; }}

	}
}
