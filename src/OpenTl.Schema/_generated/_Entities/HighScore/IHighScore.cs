// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IHighScore : IObject
    {
       int Pos {get; set;}

       int UserId {get; set;}

       int Score {get; set;}

    }
}
