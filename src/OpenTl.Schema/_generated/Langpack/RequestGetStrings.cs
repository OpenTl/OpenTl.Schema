// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xefea3803)]
    public sealed class RequestGetStrings : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ILangPackString>>
    {
       /// <summary>Binary representation for the 'LangPack' property</summary>
       [SerializationOrder(0)]
       public byte[] LangPackAsBinary { get => _LangPackAsBinary; set { _LangPack = Encoding.UTF8.GetString(value); _LangPackAsBinary = value; }}
       private byte[] _LangPackAsBinary;
       private string _LangPack;
       public string LangPack { get => _LangPack; set { LangPackAsBinary = Encoding.UTF8.GetBytes(value); _LangPack = value; }}

       /// <summary>Binary representation for the 'LangCode' property</summary>
       [SerializationOrder(1)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<string> Keys {get; set;}

    }
}
