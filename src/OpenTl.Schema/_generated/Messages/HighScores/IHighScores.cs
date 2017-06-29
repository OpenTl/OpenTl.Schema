// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IHighScores : IObject
    {
        TVector<IHighScore> Scores {get; set;}

        TVector<IUser> Users {get; set;}

    }
}
