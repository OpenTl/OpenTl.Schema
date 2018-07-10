// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4679b65f)]
	public sealed class TAccessPointRule : IAccessPointRule
	{
       /// <summary>Binary representation for the 'PhonePrefixRules' property</summary>
       [SerializationOrder(0)]
       public byte[] PhonePrefixRulesAsBinary { get => _PhonePrefixRulesAsBinary; set { _PhonePrefixRules = Encoding.UTF8.GetString(value); _PhonePrefixRulesAsBinary = value; }}
       private byte[] _PhonePrefixRulesAsBinary;
       private string _PhonePrefixRules;
       public string PhonePrefixRules { get => _PhonePrefixRules; set { PhonePrefixRulesAsBinary = Encoding.UTF8.GetBytes(value); _PhonePrefixRules = value; }}

       [SerializationOrder(1)]
       public int DcId {get; set;}

       [SerializationOrder(2)]
       [BareTypeAttribute]
       public TVector<OpenTl.Schema.IIpPort> Ips {get; set;}

	}
}
