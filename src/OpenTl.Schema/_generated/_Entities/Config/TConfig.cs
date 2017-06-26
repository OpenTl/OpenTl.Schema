// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb601684)]
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
       public TVector<IDcOption> DcOptions {get; set;}

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
       public string MeUrlPrefix {get; set;}

       [SerializationOrder(30)]
       public TVector<IDisabledFeature> DisabledFeatures {get; set;}

	}
}
