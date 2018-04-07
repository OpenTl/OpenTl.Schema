// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x137948a5)]
	public sealed class TPasswordRecovery : IPasswordRecovery
	{
       /// <summary>Binary representation for the 'EmailPattern' property</summary>
       [SerializationOrder(0)]
       public byte[] EmailPatternAsBinary { get => _EmailPatternAsBinary; set { _EmailPattern = Encoding.UTF8.GetString(value); _EmailPatternAsBinary = value; }}
       private byte[] _EmailPatternAsBinary;
       private string _EmailPattern;
       public string EmailPattern { get => _EmailPattern; set { EmailPatternAsBinary = Encoding.UTF8.GetBytes(value); _EmailPattern = value; }}

	}
}
