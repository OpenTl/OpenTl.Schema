// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x899fe31d)]
    public sealed class RequestSaveSecureValue : IRequest<OpenTl.Schema.ISecureValue>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputSecureValue Value {get; set;}

       [SerializationOrder(1)]
       public long SecureSecretId {get; set;}

    }
}
