// ReSharper disable All

namespace OpenTl.Schema.Photos
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoto : IObject
    {
       OpenTl.Schema.IPhoto Photo {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
