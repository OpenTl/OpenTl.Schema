// ReSharper disable All

namespace OpenTl.Schema.Phone
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoneCall : IObject
    {
       OpenTl.Schema.IPhoneCall PhoneCall {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
