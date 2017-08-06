// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPeerSettings : IObject
    {
       BitArray Flags {get; set;}

       bool ReportSpam {get; set;}

    }
}
