// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e1ee318)]
    public class RequestGetStrings : IRequest<TVector<ILangPackString>>
    {
       [SerializationOrder(0)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

       [SerializationOrder(1)]
       public TVector<string> Keys {get; set;}

    }
}
