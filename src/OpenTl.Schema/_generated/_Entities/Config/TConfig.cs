// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7feec888)]
	public class TConfig : IConfig
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool PhonecallsEnabled {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       public int Expires {get; set;}

       [SerializationOrder(4)]
       public bool TestMode {get; set;}

       [SerializationOrder(5)]
       public int ThisDc {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDcOption> DcOptions {get; set;}

       [SerializationOrder(7)]
       public int ChatSizeMax {get; set;}

       [SerializationOrder(8)]
       public int MegagroupSizeMax {get; set;}

       [SerializationOrder(9)]
       public int ForwardedCountMax {get; set;}

       [SerializationOrder(10)]
       public int OnlineUpdatePeriodMs {get; set;}

       [SerializationOrder(11)]
       public int OfflineBlurTimeoutMs {get; set;}

       [SerializationOrder(12)]
       public int OfflineIdleTimeoutMs {get; set;}

       [SerializationOrder(13)]
       public int OnlineCloudTimeoutMs {get; set;}

       [SerializationOrder(14)]
       public int NotifyCloudDelayMs {get; set;}

       [SerializationOrder(15)]
       public int NotifyDefaultDelayMs {get; set;}

       [SerializationOrder(16)]
       public int ChatBigSize {get; set;}

       [SerializationOrder(17)]
       public int PushChatPeriodMs {get; set;}

       [SerializationOrder(18)]
       public int PushChatLimit {get; set;}

       [SerializationOrder(19)]
       public int SavedGifsLimit {get; set;}

       [SerializationOrder(20)]
       public int EditTimeLimit {get; set;}

       [SerializationOrder(21)]
       public int RatingEDecay {get; set;}

       [SerializationOrder(22)]
       public int StickersRecentLimit {get; set;}

       [SerializationOrder(23)]
       [CanSerialize("Flags", 0)]
       public int TmpSessions {get; set;}

       [SerializationOrder(24)]
       public int PinnedDialogsCountMax {get; set;}

       [SerializationOrder(25)]
       public int CallReceiveTimeoutMs {get; set;}

       [SerializationOrder(26)]
       public int CallRingTimeoutMs {get; set;}

       [SerializationOrder(27)]
       public int CallConnectTimeoutMs {get; set;}

       [SerializationOrder(28)]
       public int CallPacketTimeoutMs {get; set;}

       [SerializationOrder(29)]
       public byte[] MeUrlPrefixAsBinary { get => _MeUrlPrefixAsBinary; set { _MeUrlPrefix = Encoding.UTF8.GetString(value); _MeUrlPrefixAsBinary = value; }}
       private byte[] _MeUrlPrefixAsBinary;
       private string _MeUrlPrefix;
       public string MeUrlPrefix { get => _MeUrlPrefix; set { MeUrlPrefixAsBinary = Encoding.UTF8.GetBytes(value); _MeUrlPrefix = value; }}

       [SerializationOrder(30)]
       [CanSerialize("Flags", 2)]
       public byte[] SuggestedLangCodeAsBinary { get => _SuggestedLangCodeAsBinary; set { _SuggestedLangCode = Encoding.UTF8.GetString(value); _SuggestedLangCodeAsBinary = value; }}
       private byte[] _SuggestedLangCodeAsBinary;
       private string _SuggestedLangCode;
       public string SuggestedLangCode { get => _SuggestedLangCode; set { SuggestedLangCodeAsBinary = Encoding.UTF8.GetBytes(value); _SuggestedLangCode = value; }}

       [SerializationOrder(31)]
       [CanSerialize("Flags", 2)]
       public int LangPackVersion {get; set;}

       [SerializationOrder(32)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDisabledFeature> DisabledFeatures {get; set;}

	}
}
