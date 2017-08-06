// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMaskCoords : IObject
    {
       int N {get; set;}

       double X {get; set;}

       double Y {get; set;}

       double Zoom {get; set;}

    }
}
