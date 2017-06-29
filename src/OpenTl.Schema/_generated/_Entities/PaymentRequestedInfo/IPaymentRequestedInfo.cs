// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentRequestedInfo : IObject
    {
        BitArray Flags {get; set;}

        string Name {get; set;}

        string Phone {get; set;}

        string Email {get; set;}

        IPostAddress ShippingAddress {get; set;}

    }
}
