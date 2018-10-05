﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7e58ee9c)]
    public sealed class RequestClearAllDrafts : IRequest<bool>
    {

    }
}
