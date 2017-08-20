// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc12622c4)]
	public class TTextUnderline : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Text {get; set;}

	}
}
