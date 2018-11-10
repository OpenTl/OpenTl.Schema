// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x6c3f19b9)]
	public sealed class TTextFixed : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

	}
}
