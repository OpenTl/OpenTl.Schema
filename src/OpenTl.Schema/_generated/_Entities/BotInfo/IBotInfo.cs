// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotInfo : IObject
    {
        int UserId {get; set;}

        string Description {get; set;}

        TVector<IBotCommand> Commands {get; set;}

    }
}
