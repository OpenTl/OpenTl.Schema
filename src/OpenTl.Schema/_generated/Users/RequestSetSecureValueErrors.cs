// ReSharper disable All

namespace OpenTl.Schema.Users
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x90c894b5)]
    public sealed class RequestSetSecureValueErrors : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Id {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueError> Errors {get; set;}

    }
}
