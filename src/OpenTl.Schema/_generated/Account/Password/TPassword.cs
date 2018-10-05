// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xad2641f8)]
	public sealed class TPassword : IPassword
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool HasRecovery {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool HasSecureValues {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool HasPassword {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IPasswordKdfAlgo CurrentAlgo {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public byte[] SrpB {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public long SrpId {get; set;}

       /// <summary>Binary representation for the 'Hint' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 3)]
       public byte[] HintAsBinary { get => _HintAsBinary; set { _Hint = Encoding.UTF8.GetString(value); _HintAsBinary = value; }}
       private byte[] _HintAsBinary;
       private string _Hint;
       public string Hint { get => _Hint; set { HintAsBinary = Encoding.UTF8.GetBytes(value); _Hint = value; }}

       /// <summary>Binary representation for the 'EmailUnconfirmedPattern' property</summary>
       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public byte[] EmailUnconfirmedPatternAsBinary { get => _EmailUnconfirmedPatternAsBinary; set { _EmailUnconfirmedPattern = Encoding.UTF8.GetString(value); _EmailUnconfirmedPatternAsBinary = value; }}
       private byte[] _EmailUnconfirmedPatternAsBinary;
       private string _EmailUnconfirmedPattern;
       public string EmailUnconfirmedPattern { get => _EmailUnconfirmedPattern; set { EmailUnconfirmedPatternAsBinary = Encoding.UTF8.GetBytes(value); _EmailUnconfirmedPattern = value; }}

       [SerializationOrder(9)]
       public OpenTl.Schema.IPasswordKdfAlgo NewAlgo {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.ISecurePasswordKdfAlgo NewSecureAlgo {get; set;}

       [SerializationOrder(11)]
       public byte[] SecureRandom {get; set;}

	}
}
