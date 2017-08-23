// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPeerDialogs : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IDialog> Dialogs {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       OpenTl.Schema.Updates.IState State {get; set;}

    }
}
