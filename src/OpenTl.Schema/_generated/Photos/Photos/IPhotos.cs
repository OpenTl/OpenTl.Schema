// ReSharper disable All

namespace OpenTl.Schema.Photos
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhotos : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPhoto> Photos {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
