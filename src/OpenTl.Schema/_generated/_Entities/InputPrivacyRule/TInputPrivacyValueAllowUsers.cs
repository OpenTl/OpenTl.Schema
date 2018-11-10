﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x131cc67f)]
	public sealed class TInputPrivacyValueAllowUsers : IInputPrivacyRule
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputUser> Users {get; set;}

	}
}
