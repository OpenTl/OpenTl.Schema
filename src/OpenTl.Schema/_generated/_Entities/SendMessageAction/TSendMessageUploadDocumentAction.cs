﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xaa0cd9e4)]
	public sealed class TSendMessageUploadDocumentAction : ISendMessageAction
	{
       [SerializationOrder(0)]
       public int Progress {get; set;}

	}
}
