// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFutureSalts : IObject
    {
       long ReqMsgId {get; set;}

       int Now {get; set;}

       TVector<OpenTl.Schema.TFutureSalt> Salts {get; set;}

    }
}
