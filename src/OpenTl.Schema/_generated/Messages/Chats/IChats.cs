// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChats : IObject
    {
       TVector<IChat> Chats {get; set;}

    }
}
