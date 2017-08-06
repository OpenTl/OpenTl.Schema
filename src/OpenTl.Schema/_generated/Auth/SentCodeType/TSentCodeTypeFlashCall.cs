// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xab03c6d9)]
	public class TSentCodeTypeFlashCall : ISentCodeType
	{
       [SerializationOrder(0)]
       public byte[] PatternAsBinary { get => _PatternAsBinary; set { _Pattern = Encoding.UTF8.GetString(value); _PatternAsBinary = value; }}
       private byte[] _PatternAsBinary;
       private string _Pattern;
       public string Pattern { get => _Pattern; set { PatternAsBinary = Encoding.UTF8.GetBytes(value); _Pattern = value; }}

	}
}
