// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3213dbba)]
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
       [FromFlag("Flags", 8)]
       public bool BlockedMode {get; set;}

       [SerializationOrder(7)]
       public int Date {get; set;}

       [SerializationOrder(8)]
       public int Expires {get; set;}

       [SerializationOrder(9)]
       public bool TestMode {get; set;}

       [SerializationOrder(10)]
       public int ThisDc {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDcOption> DcOptions {get; set;}

       /// <summary>Binary representation for the 'DcTxtDomainName' property</summary>
       [SerializationOrder(12)]
       public byte[] DcTxtDomainNameAsBinary { get => _DcTxtDomainNameAsBinary; set { _DcTxtDomainName = Encoding.UTF8.GetString(value); _DcTxtDomainNameAsBinary = value; }}
       private byte[] _DcTxtDomainNameAsBinary;
       private string _DcTxtDomainName;
       public string DcTxtDomainName { get => _DcTxtDomainName; set { DcTxtDomainNameAsBinary = Encoding.UTF8.GetBytes(value); _DcTxtDomainName = value; }}

       [SerializationOrder(13)]
       public int ChatSizeMax {get; set;}

       [SerializationOrder(14)]
       public int MegagroupSizeMax {get; set;}

       [SerializationOrder(15)]
       public int ForwardedCountMax {get; set;}

       [SerializationOrder(16)]
       public int OnlineUpdatePeriodMs {get; set;}

       [SerializationOrder(17)]
       public int OfflineBlurTimeoutMs {get; set;}

       [SerializationOrder(18)]
       public int OfflineIdleTimeoutMs {get; set;}

       [SerializationOrder(19)]
       public int OnlineCloudTimeoutMs {get; set;}

       [SerializationOrder(20)]
       public int NotifyCloudDelayMs {get; set;}

       [SerializationOrder(21)]
       public int NotifyDefaultDelayMs {get; set;}

       [SerializationOrder(22)]
       public int PushChatPeriodMs {get; set;}

       [SerializationOrder(23)]
       public int PushChatLimit {get; set;}

       [SerializationOrder(24)]
       public int SavedGifsLimit {get; set;}

       [SerializationOrder(25)]
       public int EditTimeLimit {get; set;}

       [SerializationOrder(26)]
       public int RevokeTimeLimit {get; set;}

       [SerializationOrder(27)]
       public int RevokePmTimeLimit {get; set;}

       [SerializationOrder(28)]
       public int RatingEDecay {get; set;}

       [SerializationOrder(29)]
       public int StickersRecentLimit {get; set;}

       [SerializationOrder(30)]
       public int StickersFavedLimit {get; set;}

       [SerializationOrder(31)]
       public int ChannelsReadMediaPeriod {get; set;}

       [SerializationOrder(32)]
       [CanSerialize("Flags", 0)]
       public int TmpSessions {get; set;}

       [SerializationOrder(33)]
       public int PinnedDialogsCountMax {get; set;}

       [SerializationOrder(34)]
       public int CallReceiveTimeoutMs {get; set;}

       [SerializationOrder(35)]
       public int CallRingTimeoutMs {get; set;}

       [SerializationOrder(36)]
       public int CallConnectTimeoutMs {get; set;}

       [SerializationOrder(37)]
       public int CallPacketTimeoutMs {get; set;}

       /// <summary>Binary representation for the 'MeUrlPrefix' property</summary>
       [SerializationOrder(38)]
       public byte[] MeUrlPrefixAsBinary { get => _MeUrlPrefixAsBinary; set { _MeUrlPrefix = Encoding.UTF8.GetString(value); _MeUrlPrefixAsBinary = value; }}
       private byte[] _MeUrlPrefixAsBinary;
       private string _MeUrlPrefix;
       public string MeUrlPrefix { get => _MeUrlPrefix; set { MeUrlPrefixAsBinary = Encoding.UTF8.GetBytes(value); _MeUrlPrefix = value; }}

       /// <summary>Binary representation for the 'AutoupdateUrlPrefix' property</summary>
       [SerializationOrder(39)]
       [CanSerialize("Flags", 7)]
       public byte[] AutoupdateUrlPrefixAsBinary { get => _AutoupdateUrlPrefixAsBinary; set { _AutoupdateUrlPrefix = Encoding.UTF8.GetString(value); _AutoupdateUrlPrefixAsBinary = value; }}
       private byte[] _AutoupdateUrlPrefixAsBinary;
       private string _AutoupdateUrlPrefix;
       public string AutoupdateUrlPrefix { get => _AutoupdateUrlPrefix; set { AutoupdateUrlPrefixAsBinary = Encoding.UTF8.GetBytes(value); _AutoupdateUrlPrefix = value; }}

       /// <summary>Binary representation for the 'GifSearchUsername' property</summary>
       [SerializationOrder(40)]
       [CanSerialize("Flags", 9)]
       public byte[] GifSearchUsernameAsBinary { get => _GifSearchUsernameAsBinary; set { _GifSearchUsername = Encoding.UTF8.GetString(value); _GifSearchUsernameAsBinary = value; }}
       private byte[] _GifSearchUsernameAsBinary;
       private string _GifSearchUsername;
       public string GifSearchUsername { get => _GifSearchUsername; set { GifSearchUsernameAsBinary = Encoding.UTF8.GetBytes(value); _GifSearchUsername = value; }}

       /// <summary>Binary representation for the 'VenueSearchUsername' property</summary>
       [SerializationOrder(41)]
       [CanSerialize("Flags", 10)]
       public byte[] VenueSearchUsernameAsBinary { get => _VenueSearchUsernameAsBinary; set { _VenueSearchUsername = Encoding.UTF8.GetString(value); _VenueSearchUsernameAsBinary = value; }}
       private byte[] _VenueSearchUsernameAsBinary;
       private string _VenueSearchUsername;
       public string VenueSearchUsername { get => _VenueSearchUsername; set { VenueSearchUsernameAsBinary = Encoding.UTF8.GetBytes(value); _VenueSearchUsername = value; }}

       /// <summary>Binary representation for the 'ImgSearchUsername' property</summary>
       [SerializationOrder(42)]
       [CanSerialize("Flags", 11)]
       public byte[] ImgSearchUsernameAsBinary { get => _ImgSearchUsernameAsBinary; set { _ImgSearchUsername = Encoding.UTF8.GetString(value); _ImgSearchUsernameAsBinary = value; }}
       private byte[] _ImgSearchUsernameAsBinary;
       private string _ImgSearchUsername;
       public string ImgSearchUsername { get => _ImgSearchUsername; set { ImgSearchUsernameAsBinary = Encoding.UTF8.GetBytes(value); _ImgSearchUsername = value; }}

       /// <summary>Binary representation for the 'StaticMapsProvider' property</summary>
       [SerializationOrder(43)]
       [CanSerialize("Flags", 12)]
       public byte[] StaticMapsProviderAsBinary { get => _StaticMapsProviderAsBinary; set { _StaticMapsProvider = Encoding.UTF8.GetString(value); _StaticMapsProviderAsBinary = value; }}
       private byte[] _StaticMapsProviderAsBinary;
       private string _StaticMapsProvider;
       public string StaticMapsProvider { get => _StaticMapsProvider; set { StaticMapsProviderAsBinary = Encoding.UTF8.GetBytes(value); _StaticMapsProvider = value; }}

       [SerializationOrder(44)]
       public int CaptionLengthMax {get; set;}

       [SerializationOrder(45)]
       public int MessageLengthMax {get; set;}

       [SerializationOrder(46)]
       public int WebfileDcId {get; set;}

       /// <summary>Binary representation for the 'SuggestedLangCode' property</summary>
       [SerializationOrder(47)]
       [CanSerialize("Flags", 2)]
       public byte[] SuggestedLangCodeAsBinary { get => _SuggestedLangCodeAsBinary; set { _SuggestedLangCode = Encoding.UTF8.GetString(value); _SuggestedLangCodeAsBinary = value; }}
       private byte[] _SuggestedLangCodeAsBinary;
       private string _SuggestedLangCode;
       public string SuggestedLangCode { get => _SuggestedLangCode; set { SuggestedLangCodeAsBinary = Encoding.UTF8.GetBytes(value); _SuggestedLangCode = value; }}

       [SerializationOrder(48)]
       [CanSerialize("Flags", 2)]
       public int LangPackVersion {get; set;}

	}
}
