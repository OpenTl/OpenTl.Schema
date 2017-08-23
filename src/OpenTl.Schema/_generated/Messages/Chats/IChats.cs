// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChats : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

    }
}
