// ReSharper disable All

namespace OpenTl.Schema.Photos
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhotos : IObject
    {
        TVector<IPhoto> Photos {get; set;}

        TVector<IUser> Users {get; set;}

    }
}
