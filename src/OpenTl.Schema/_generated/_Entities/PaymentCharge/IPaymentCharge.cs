// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentCharge : IObject
    {
        string Id {get; set;}

        string ProviderChargeId {get; set;}

    }
}
