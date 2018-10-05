﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9880f658)]
	public sealed class TInputCheckPasswordEmpty : IInputCheckPasswordSRP, IEmpty
	{

	}
}
