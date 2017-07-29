﻿// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICdnFileHash : IObject
    {
        int Offset {get; set;}

        int Limit {get; set;}

        byte[] Hash {get; set;}

    }
}
