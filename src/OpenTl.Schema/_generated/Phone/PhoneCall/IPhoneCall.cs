// ReSharper disable All

namespace OpenTl.Schema.Phone
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoneCall : IObject
    {
        IPhoneCall PhoneCall {get; set;}

        TVector<IUser> Users {get; set;}

    }
}
