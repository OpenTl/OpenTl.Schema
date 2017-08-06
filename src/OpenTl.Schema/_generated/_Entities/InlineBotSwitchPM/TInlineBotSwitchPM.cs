// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c20629f)]
	public class TInlineBotSwitchPM : IInlineBotSwitchPM
	{
       [SerializationOrder(0)]
       public byte[] ExtAsBinary { get => _ExtAsBinary; set { _Ext = Encoding.UTF8.GetString(value); _ExtAsBinary = value; }}
       private byte[] _ExtAsBinary;
       private string _Ext;
       public string Ext { get => _Ext; set { ExtAsBinary = Encoding.UTF8.GetBytes(value); _Ext = value; }}

       [SerializationOrder(1)]
       public byte[] StartParamAsBinary { get => _StartParamAsBinary; set { _StartParam = Encoding.UTF8.GetString(value); _StartParamAsBinary = value; }}
       private byte[] _StartParamAsBinary;
       private string _StartParam;
       public string StartParam { get => _StartParam; set { StartParamAsBinary = Encoding.UTF8.GetBytes(value); _StartParam = value; }}

	}
}
