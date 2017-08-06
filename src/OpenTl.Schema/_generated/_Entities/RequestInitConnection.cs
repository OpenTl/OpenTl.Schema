// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7481da6)]
    public class RequestInitConnection : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public int ApiId {get; set;}

       [SerializationOrder(1)]
       public byte[] DeviceModelAsBinary { get => _DeviceModelAsBinary; set { _DeviceModel = Encoding.UTF8.GetString(value); _DeviceModelAsBinary = value; }}
       private byte[] _DeviceModelAsBinary;
       private string _DeviceModel;
       public string DeviceModel { get => _DeviceModel; set { DeviceModelAsBinary = Encoding.UTF8.GetBytes(value); _DeviceModel = value; }}

       [SerializationOrder(2)]
       public byte[] SystemVersionAsBinary { get => _SystemVersionAsBinary; set { _SystemVersion = Encoding.UTF8.GetString(value); _SystemVersionAsBinary = value; }}
       private byte[] _SystemVersionAsBinary;
       private string _SystemVersion;
       public string SystemVersion { get => _SystemVersion; set { SystemVersionAsBinary = Encoding.UTF8.GetBytes(value); _SystemVersion = value; }}

       [SerializationOrder(3)]
       public byte[] AppVersionAsBinary { get => _AppVersionAsBinary; set { _AppVersion = Encoding.UTF8.GetString(value); _AppVersionAsBinary = value; }}
       private byte[] _AppVersionAsBinary;
       private string _AppVersion;
       public string AppVersion { get => _AppVersion; set { AppVersionAsBinary = Encoding.UTF8.GetBytes(value); _AppVersion = value; }}

       [SerializationOrder(4)]
       public byte[] SystemLangCodeAsBinary { get => _SystemLangCodeAsBinary; set { _SystemLangCode = Encoding.UTF8.GetString(value); _SystemLangCodeAsBinary = value; }}
       private byte[] _SystemLangCodeAsBinary;
       private string _SystemLangCode;
       public string SystemLangCode { get => _SystemLangCode; set { SystemLangCodeAsBinary = Encoding.UTF8.GetBytes(value); _SystemLangCode = value; }}

       [SerializationOrder(5)]
       public byte[] LangPackAsBinary { get => _LangPackAsBinary; set { _LangPack = Encoding.UTF8.GetString(value); _LangPackAsBinary = value; }}
       private byte[] _LangPackAsBinary;
       private string _LangPack;
       public string LangPack { get => _LangPack; set { LangPackAsBinary = Encoding.UTF8.GetBytes(value); _LangPack = value; }}

       [SerializationOrder(6)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

       [SerializationOrder(7)]
       public IObject Query {get; set;}

    }
}
