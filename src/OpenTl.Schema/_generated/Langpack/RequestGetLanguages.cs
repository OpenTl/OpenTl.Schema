// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x42c6978f)]
    public sealed class RequestGetLanguages : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ILangPackLanguage>>
    {
       /// <summary>Binary representation for the 'LangPack' property</summary>
       [SerializationOrder(0)]
       public byte[] LangPackAsBinary { get => _LangPackAsBinary; set { _LangPack = Encoding.UTF8.GetString(value); _LangPackAsBinary = value; }}
       private byte[] _LangPackAsBinary;
       private string _LangPack;
       public string LangPack { get => _LangPack; set { LangPackAsBinary = Encoding.UTF8.GetBytes(value); _LangPack = value; }}

    }
}
