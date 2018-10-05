// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x449e0b51)]
    public sealed class RequestGetTmpPassword : IRequest<OpenTl.Schema.Account.ITmpPassword>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputCheckPasswordSRP Password {get; set;}

       [SerializationOrder(1)]
       public int Period {get; set;}

    }
}
