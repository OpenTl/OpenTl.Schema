// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86aef0ec)]
    public class RequestSendCode : IRequest<Auth.ISentCode>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool AllowFlashcall {get; set;}

       [SerializationOrder(2)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public bool CurrentNumber {get; set;}

       [SerializationOrder(4)]
       public int ApiId {get; set;}

       [SerializationOrder(5)]
       public string ApiHash {get; set;}

    }
}
