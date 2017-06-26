// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcdd42a05)]
    public class RequestBindTempAuthKey : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long PermAuthKeyId {get; set;}

       [SerializationOrder(1)]
       public long Nonce {get; set;}

       [SerializationOrder(2)]
       public int ExpiresAt {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(3)]
       public byte[] EncryptedMessage {get; set;}

    }
}
