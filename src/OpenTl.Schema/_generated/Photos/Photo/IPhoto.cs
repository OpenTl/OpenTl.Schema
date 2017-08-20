// ReSharper disable All

namespace OpenTl.Schema.Photos
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoto : IObject
    {
       IPhoto Photo {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
