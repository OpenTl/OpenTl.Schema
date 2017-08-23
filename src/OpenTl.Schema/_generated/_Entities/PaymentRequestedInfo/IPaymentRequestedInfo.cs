// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentRequestedInfo : IObject
    {
       BitArray Flags {get; set;}

       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

       byte[] PhoneAsBinary {get; set;}
       string Phone {get; set;}

       byte[] EmailAsBinary {get; set;}
       string Email {get; set;}

       OpenTl.Schema.IPostAddress ShippingAddress {get; set;}

    }
}
