// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9010ef6f)]
    public sealed class RequestGetAppChangelog : IRequest<OpenTl.Schema.IUpdates>
    {
       /// <summary>Binary representation for the 'PrevAppVersion' property</summary>
       [SerializationOrder(0)]
       public byte[] PrevAppVersionAsBinary { get => _PrevAppVersionAsBinary; set { _PrevAppVersion = Encoding.UTF8.GetString(value); _PrevAppVersionAsBinary = value; }}
       private byte[] _PrevAppVersionAsBinary;
       private string _PrevAppVersion;
       public string PrevAppVersion { get => _PrevAppVersion; set { PrevAppVersionAsBinary = Encoding.UTF8.GetBytes(value); _PrevAppVersion = value; }}

    }
}
