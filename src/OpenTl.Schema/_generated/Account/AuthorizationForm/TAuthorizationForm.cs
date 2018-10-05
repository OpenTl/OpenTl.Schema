// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xad2e1cd8)]
	public sealed class TAuthorizationForm : IAuthorizationForm
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureRequiredType> RequiredTypes {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValue> Values {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueError> Errors {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       /// <summary>Binary representation for the 'PrivacyPolicyUrl' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public byte[] PrivacyPolicyUrlAsBinary { get => _PrivacyPolicyUrlAsBinary; set { _PrivacyPolicyUrl = Encoding.UTF8.GetString(value); _PrivacyPolicyUrlAsBinary = value; }}
       private byte[] _PrivacyPolicyUrlAsBinary;
       private string _PrivacyPolicyUrl;
       public string PrivacyPolicyUrl { get => _PrivacyPolicyUrl; set { PrivacyPolicyUrlAsBinary = Encoding.UTF8.GetBytes(value); _PrivacyPolicyUrl = value; }}

	}
}
