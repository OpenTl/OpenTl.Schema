// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x800fd57d)]
    public sealed class RequestGetLanguages : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ILangPackLanguage>>
    {

    }
}
