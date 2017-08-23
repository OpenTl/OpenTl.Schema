// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4a82327e)]
    public class RequestGetTmpPassword : IRequest<OpenTl.Schema.Account.ITmpPassword>
    {
       [SerializationOrder(0)]
       public byte[] PasswordHash {get; set;}

       [SerializationOrder(1)]
       public int Period {get; set;}

    }
}
