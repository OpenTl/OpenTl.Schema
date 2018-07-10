// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe7027c94)]
    public sealed class RequestAcceptAuthorization : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int BotId {get; set;}

       /// <summary>Binary representation for the 'Scope' property</summary>
       [SerializationOrder(1)]
       public byte[] ScopeAsBinary { get => _ScopeAsBinary; set { _Scope = Encoding.UTF8.GetString(value); _ScopeAsBinary = value; }}
       private byte[] _ScopeAsBinary;
       private string _Scope;
       public string Scope { get => _Scope; set { ScopeAsBinary = Encoding.UTF8.GetBytes(value); _Scope = value; }}

       /// <summary>Binary representation for the 'PublicKey' property</summary>
       [SerializationOrder(2)]
       public byte[] PublicKeyAsBinary { get => _PublicKeyAsBinary; set { _PublicKey = Encoding.UTF8.GetString(value); _PublicKeyAsBinary = value; }}
       private byte[] _PublicKeyAsBinary;
       private string _PublicKey;
       public string PublicKey { get => _PublicKey; set { PublicKeyAsBinary = Encoding.UTF8.GetBytes(value); _PublicKey = value; }}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueHash> ValueHashes {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.ISecureCredentialsEncrypted Credentials {get; set;}

    }
}
