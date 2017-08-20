// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentCharge : IObject
    {
       byte[] IdAsBinary {get; set;}
       string Id {get; set;}

       byte[] ProviderChargeIdAsBinary {get; set;}
       string ProviderChargeId {get; set;}

    }
}
