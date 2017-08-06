// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IExportedAuthorization : IObject
    {
       int Id {get; set;}

       byte[] Bytes {get; set;}

    }
}
