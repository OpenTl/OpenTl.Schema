// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86b5778e)]
	public sealed class TConfig : IConfig
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool PhonecallsEnabled {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool DefaultP2pContacts {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 4)]
       public bool PreloadFeaturedStickers {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 5)]
       public bool IgnorePhoneEntities {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 6)]
       public bool RevokePmInbox {get; set;}

       [SerializationOrder(6)]
       public int Date {get; set;}

       [SerializationOrder(7)]
       public int Expires {get; set;}

       [SerializationOrder(8)]
       public bool TestMode {get; set;}

       [SerializationOrder(9)]
       public int ThisDc {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDcOption> DcOptions {get; set;}

       [SerializationOrder(11)]
       public int ChatSizeMax {get; set;}

       [SerializationOrder(12)]
       public int MegagroupSizeMax {get; set;}

       [SerializationOrder(13)]
       public int ForwardedCountMax {get; set;}

       [SerializationOrder(14)]
       public int OnlineUpdatePeriodMs {get; set;}

       [SerializationOrder(15)]
       public int OfflineBlurTimeoutMs {get; set;}

       [SerializationOrder(16)]
       public int OfflineIdleTimeoutMs {get; set;}

       [SerializationOrder(17)]
       public int OnlineCloudTimeoutMs {get; set;}

       [SerializationOrder(18)]
       public int NotifyCloudDelayMs {get; set;}

       [SerializationOrder(19)]
       public int NotifyDefaultDelayMs {get; set;}

       [SerializationOrder(20)]
       public int PushChatPeriodMs {get; set;}

       [SerializationOrder(21)]
       public int PushChatLimit {get; set;}

       [SerializationOrder(22)]
       public int SavedGifsLimit {get; set;}

       [SerializationOrder(23)]
       public int EditTimeLimit {get; set;}

       [SerializationOrder(24)]
       public int RevokeTimeLimit {get; set;}

       [SerializationOrder(25)]
       public int RevokePmTimeLimit {get; set;}

       [SerializationOrder(26)]
       public int RatingEDecay {get; set;}

       [SerializationOrder(27)]
       public int StickersRecentLimit {get; set;}

       [SerializationOrder(28)]
       public int StickersFavedLimit {get; set;}

       [SerializationOrder(29)]
       public int ChannelsReadMediaPeriod {get; set;}

       [SerializationOrder(30)]
       [CanSerialize("Flags", 0)]
       public int TmpSessions {get; set;}

       [SerializationOrder(31)]
       public int PinnedDialogsCountMax {get; set;}

       [SerializationOrder(32)]
       public int CallReceiveTimeoutMs {get; set;}

       [SerializationOrder(33)]
       public int CallRingTimeoutMs {get; set;}

       [SerializationOrder(34)]
       public int CallConnectTimeoutMs {get; set;}

       [SerializationOrder(35)]
       public int CallPacketTimeoutMs {get; set;}

       /// <summary>Binary representation for the 'MeUrlPrefix' property</summary>
       [SerializationOrder(36)]
       public byte[] MeUrlPrefixAsBinary { get => _MeUrlPrefixAsBinary; set { _MeUrlPrefix = Encoding.UTF8.GetString(value); _MeUrlPrefixAsBinary = value; }}
       private byte[] _MeUrlPrefixAsBinary;
       private string _MeUrlPrefix;
       public string MeUrlPrefix { get => _MeUrlPrefix; set { MeUrlPrefixAsBinary = Encoding.UTF8.GetBytes(value); _MeUrlPrefix = value; }}

       /// <summary>Binary representation for the 'SuggestedLangCode' property</summary>
       [SerializationOrder(37)]
       [CanSerialize("Flags", 2)]
       public byte[] SuggestedLangCodeAsBinary { get => _SuggestedLangCodeAsBinary; set { _SuggestedLangCode = Encoding.UTF8.GetString(value); _SuggestedLangCodeAsBinary = value; }}
       private byte[] _SuggestedLangCodeAsBinary;
       private string _SuggestedLangCode;
       public string SuggestedLangCode { get => _SuggestedLangCode; set { SuggestedLangCodeAsBinary = Encoding.UTF8.GetBytes(value); _SuggestedLangCode = value; }}

       [SerializationOrder(38)]
       [CanSerialize("Flags", 2)]
       public int LangPackVersion {get; set;}

	}
}
