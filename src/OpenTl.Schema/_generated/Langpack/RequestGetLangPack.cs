// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9ab5c58e)]
    public sealed class RequestGetLangPack : IRequest<OpenTl.Schema.ILangPackDifference>
    {
       /// <summary>Binary representation for the 'LangCode' property</summary>
       [SerializationOrder(0)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

    }
}
