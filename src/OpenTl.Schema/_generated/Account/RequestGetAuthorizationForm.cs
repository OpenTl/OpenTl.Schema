// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb86ba8e1)]
    public sealed class RequestGetAuthorizationForm : IRequest<OpenTl.Schema.Account.IAuthorizationForm>
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

    }
}
