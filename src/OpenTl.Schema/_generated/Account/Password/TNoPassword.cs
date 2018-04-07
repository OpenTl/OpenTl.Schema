// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x96dabc18)]
	public sealed class TNoPassword : IPassword
	{
       [SerializationOrder(0)]
       public byte[] NewSalt {get; set;}

       /// <summary>Binary representation for the 'EmailUnconfirmedPattern' property</summary>
       [SerializationOrder(1)]
       public byte[] EmailUnconfirmedPatternAsBinary { get => _EmailUnconfirmedPatternAsBinary; set { _EmailUnconfirmedPattern = Encoding.UTF8.GetString(value); _EmailUnconfirmedPatternAsBinary = value; }}
       private byte[] _EmailUnconfirmedPatternAsBinary;
       private string _EmailUnconfirmedPattern;
       public string EmailUnconfirmedPattern { get => _EmailUnconfirmedPattern; set { EmailUnconfirmedPatternAsBinary = Encoding.UTF8.GetBytes(value); _EmailUnconfirmedPattern = value; }}

	}
}
