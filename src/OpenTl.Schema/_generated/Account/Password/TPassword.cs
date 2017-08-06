// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c18141c)]
	public class TPassword : IPassword
	{
       [SerializationOrder(0)]
       public byte[] CurrentSalt {get; set;}

       [SerializationOrder(1)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(2)]
       public byte[] HintAsBinary { get => _HintAsBinary; set { _Hint = Encoding.UTF8.GetString(value); _HintAsBinary = value; }}
       private byte[] _HintAsBinary;
       private string _Hint;
       public string Hint { get => _Hint; set { HintAsBinary = Encoding.UTF8.GetBytes(value); _Hint = value; }}

       [SerializationOrder(3)]
       public bool HasRecovery {get; set;}

       [SerializationOrder(4)]
       public byte[] EmailUnconfirmedPatternAsBinary { get => _EmailUnconfirmedPatternAsBinary; set { _EmailUnconfirmedPattern = Encoding.UTF8.GetString(value); _EmailUnconfirmedPatternAsBinary = value; }}
       private byte[] _EmailUnconfirmedPatternAsBinary;
       private string _EmailUnconfirmedPattern;
       public string EmailUnconfirmedPattern { get => _EmailUnconfirmedPattern; set { EmailUnconfirmedPatternAsBinary = Encoding.UTF8.GetBytes(value); _EmailUnconfirmedPattern = value; }}

	}
}
