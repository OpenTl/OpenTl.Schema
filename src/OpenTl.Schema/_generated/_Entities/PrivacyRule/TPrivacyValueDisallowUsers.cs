﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xc7f49b7)]
	public sealed class TPrivacyValueDisallowUsers : IPrivacyRule
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Users {get; set;}

	}
}
