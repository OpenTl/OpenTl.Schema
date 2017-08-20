// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputPhoneCall : IObject
    {
       long Id {get; set;}

       long AccessHash {get; set;}

    }
}
