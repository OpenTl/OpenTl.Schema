// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChatFull : IObject
    {
       Schema.IChatFull FullChat {get; set;}

       TVector<IChat> Chats {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
