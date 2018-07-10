// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAccessPointRule : IObject
    {
       byte[] PhonePrefixRulesAsBinary {get; set;}
       string PhonePrefixRules {get; set;}

       int DcId {get; set;}

       TVector<OpenTl.Schema.IIpPort> Ips {get; set;}

    }
}
