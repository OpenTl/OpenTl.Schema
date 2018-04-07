
var camelCaseTokenizer = function (obj) {
    var previous = '';
    return obj.toString().trim().split(/[\s\-]+|(?=[A-Z])/).reduce(function(acc, cur) {
        var current = cur.toLowerCase();
        if(acc.length === 0) {
            previous = current;
            return acc.concat(current);
        }
        previous = previous.concat(current);
        return acc.concat([current, previous]);
    }, []);
}
lunr.tokenizer.registerFunction(camelCaseTokenizer, 'camelCaseTokenizer')
var searchModule = function() {
    var idMap = [];
    function y(e) { 
        idMap.push(e); 
    }
    var idx = lunr(function() {
        this.field('title', { boost: 10 });
        this.field('content');
        this.field('description', { boost: 5 });
        this.field('tags', { boost: 50 });
        this.ref('id');
        this.tokenizer(camelCaseTokenizer);

        this.pipeline.remove(lunr.stopWordFilter);
        this.pipeline.remove(lunr.stemmer);
    });
    function a(e) { 
        idx.add(e); 
    }

    a({
        id:0,
        title:"TSendMessageUploadVideoAction",
        content:"TSendMessageUploadVideoAction",
        description:'',
        tags:''
    });

    a({
        id:1,
        title:"TPrivacyValueAllowUsers",
        content:"TPrivacyValueAllowUsers",
        description:'',
        tags:''
    });

    a({
        id:2,
        title:"TInputPaymentCredentialsApplePay",
        content:"TInputPaymentCredentialsApplePay",
        description:'',
        tags:''
    });

    a({
        id:3,
        title:"RequestStartBot",
        content:"RequestStartBot",
        description:'',
        tags:''
    });

    a({
        id:4,
        title:"TTopPeerCategoryBotsPM",
        content:"TTopPeerCategoryBotsPM",
        description:'',
        tags:''
    });

    a({
        id:5,
        title:"IFound",
        content:"IFound",
        description:'',
        tags:''
    });

    a({
        id:6,
        title:"TChannelMessages",
        content:"TChannelMessages",
        description:'',
        tags:''
    });

    a({
        id:7,
        title:"RequestSaveFilePart",
        content:"RequestSaveFilePart",
        description:'',
        tags:''
    });

    a({
        id:8,
        title:"TInputMessagesFilterVideo",
        content:"TInputMessagesFilterVideo",
        description:'',
        tags:''
    });

    a({
        id:9,
        title:"IPaymentCharge",
        content:"IPaymentCharge",
        description:'',
        tags:''
    });

    a({
        id:10,
        title:"TBotCommand",
        content:"TBotCommand",
        description:'',
        tags:''
    });

    a({
        id:11,
        title:"IAuthorizations",
        content:"IAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:12,
        title:"IPhoneCall",
        content:"IPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:13,
        title:"IInlineBotSwitchPM",
        content:"IInlineBotSwitchPM",
        description:'',
        tags:''
    });

    a({
        id:14,
        title:"TMessageMediaInvoice",
        content:"TMessageMediaInvoice",
        description:'',
        tags:''
    });

    a({
        id:15,
        title:"TUpdatesCombined",
        content:"TUpdatesCombined",
        description:'',
        tags:''
    });

    a({
        id:16,
        title:"RequestReadMessageContents",
        content:"RequestReadMessageContents",
        description:'',
        tags:''
    });

    a({
        id:17,
        title:"TGeoPoint",
        content:"TGeoPoint",
        description:'',
        tags:''
    });

    a({
        id:18,
        title:"IInputPeerCommon",
        content:"IInputPeerCommon",
        description:'',
        tags:''
    });

    a({
        id:19,
        title:"IWebPageCommon",
        content:"IWebPageCommon",
        description:'',
        tags:''
    });

    a({
        id:20,
        title:"TFoundGifCached",
        content:"TFoundGifCached",
        description:'',
        tags:''
    });

    a({
        id:21,
        title:"RequestGetCdnFile",
        content:"RequestGetCdnFile",
        description:'',
        tags:''
    });

    a({
        id:22,
        title:"RequestSetInlineGameScore",
        content:"RequestSetInlineGameScore",
        description:'',
        tags:''
    });

    a({
        id:23,
        title:"TChatParticipantAdmin",
        content:"TChatParticipantAdmin",
        description:'',
        tags:''
    });

    a({
        id:24,
        title:"IBlocked",
        content:"IBlocked",
        description:'',
        tags:''
    });

    a({
        id:25,
        title:"TMessageMediaPhoto",
        content:"TMessageMediaPhoto",
        description:'',
        tags:''
    });

    a({
        id:26,
        title:"TChannelDifference",
        content:"TChannelDifference",
        description:'',
        tags:''
    });

    a({
        id:27,
        title:"RequestSetAccountTTL",
        content:"RequestSetAccountTTL",
        description:'',
        tags:''
    });

    a({
        id:28,
        title:"IChannelDifference",
        content:"IChannelDifference",
        description:'',
        tags:''
    });

    a({
        id:29,
        title:"TWebDocumentNoProxy",
        content:"TWebDocumentNoProxy",
        description:'',
        tags:''
    });

    a({
        id:30,
        title:"TFileMp",
        content:"TFileMp",
        description:'',
        tags:''
    });

    a({
        id:31,
        title:"TDialog",
        content:"TDialog",
        description:'',
        tags:''
    });

    a({
        id:32,
        title:"TChannelBannedRights",
        content:"TChannelBannedRights",
        description:'',
        tags:''
    });

    a({
        id:33,
        title:"IPassword",
        content:"IPassword",
        description:'',
        tags:''
    });

    a({
        id:34,
        title:"TConfigSimple",
        content:"TConfigSimple",
        description:'',
        tags:''
    });

    a({
        id:35,
        title:"TVector",
        content:"TVector",
        description:'',
        tags:''
    });

    a({
        id:36,
        title:"TUpdateReadChannelInbox",
        content:"TUpdateReadChannelInbox",
        description:'',
        tags:''
    });

    a({
        id:37,
        title:"TDestroySessionNone",
        content:"TDestroySessionNone",
        description:'',
        tags:''
    });

    a({
        id:38,
        title:"TUpdateFavedStickers",
        content:"TUpdateFavedStickers",
        description:'',
        tags:''
    });

    a({
        id:39,
        title:"RequestAcceptCall",
        content:"RequestAcceptCall",
        description:'',
        tags:''
    });

    a({
        id:40,
        title:"TUpdateRecentStickers",
        content:"TUpdateRecentStickers",
        description:'',
        tags:''
    });

    a({
        id:41,
        title:"TPassword",
        content:"TPassword",
        description:'',
        tags:''
    });

    a({
        id:42,
        title:"TInputBotInlineMessageMediaAuto",
        content:"TInputBotInlineMessageMediaAuto",
        description:'',
        tags:''
    });

    a({
        id:43,
        title:"IRichText",
        content:"IRichText",
        description:'',
        tags:''
    });

    a({
        id:44,
        title:"IBotInlineMessage",
        content:"IBotInlineMessage",
        description:'',
        tags:''
    });

    a({
        id:45,
        title:"RequestSetPrivacy",
        content:"RequestSetPrivacy",
        description:'',
        tags:''
    });

    a({
        id:46,
        title:"RequestDeleteUserHistory",
        content:"RequestDeleteUserHistory",
        description:'',
        tags:''
    });

    a({
        id:47,
        title:"TLabeledPrice",
        content:"TLabeledPrice",
        description:'',
        tags:''
    });

    a({
        id:48,
        title:"TDestroyAuthKeyFail",
        content:"TDestroyAuthKeyFail",
        description:'',
        tags:''
    });

    a({
        id:49,
        title:"TPeerChat",
        content:"TPeerChat",
        description:'',
        tags:''
    });

    a({
        id:50,
        title:"IPage",
        content:"IPage",
        description:'',
        tags:''
    });

    a({
        id:51,
        title:"TSendMessageUploadPhotoAction",
        content:"TSendMessageUploadPhotoAction",
        description:'',
        tags:''
    });

    a({
        id:52,
        title:"TKeyboardButtonCallback",
        content:"TKeyboardButtonCallback",
        description:'',
        tags:''
    });

    a({
        id:53,
        title:"IReplyMarkup",
        content:"IReplyMarkup",
        description:'',
        tags:''
    });

    a({
        id:54,
        title:"TInputMessagesFilterMusic",
        content:"TInputMessagesFilterMusic",
        description:'',
        tags:''
    });

    a({
        id:55,
        title:"IInvoice",
        content:"IInvoice",
        description:'',
        tags:''
    });

    a({
        id:56,
        title:"RequestCancelCode",
        content:"RequestCancelCode",
        description:'',
        tags:''
    });

    a({
        id:57,
        title:"TInputMediaContact",
        content:"TInputMediaContact",
        description:'',
        tags:''
    });

    a({
        id:58,
        title:"RequestSaveAppLog",
        content:"RequestSaveAppLog",
        description:'',
        tags:''
    });

    a({
        id:59,
        title:"TAuthorizations",
        content:"TAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:60,
        title:"TPhoneCallEmpty",
        content:"TPhoneCallEmpty",
        description:'',
        tags:''
    });

    a({
        id:61,
        title:"RequestSearchGifs",
        content:"RequestSearchGifs",
        description:'',
        tags:''
    });

    a({
        id:62,
        title:"TPrivacyValueDisallowAll",
        content:"TPrivacyValueDisallowAll",
        description:'',
        tags:''
    });

    a({
        id:63,
        title:"TFilePartial",
        content:"TFilePartial",
        description:'',
        tags:''
    });

    a({
        id:64,
        title:"TInputPrivacyValueAllowAll",
        content:"TInputPrivacyValueAllowAll",
        description:'',
        tags:''
    });

    a({
        id:65,
        title:"TMsgNewDetailedInfo",
        content:"TMsgNewDetailedInfo",
        description:'',
        tags:''
    });

    a({
        id:66,
        title:"TUpdateStickerSets",
        content:"TUpdateStickerSets",
        description:'',
        tags:''
    });

    a({
        id:67,
        title:"RequestReceivedCall",
        content:"RequestReceivedCall",
        description:'',
        tags:''
    });

    a({
        id:68,
        title:"TChannelParticipantBanned",
        content:"TChannelParticipantBanned",
        description:'',
        tags:''
    });

    a({
        id:69,
        title:"TUpdateContactLink",
        content:"TUpdateContactLink",
        description:'',
        tags:''
    });

    a({
        id:70,
        title:"RequestGetPrivacy",
        content:"RequestGetPrivacy",
        description:'',
        tags:''
    });

    a({
        id:71,
        title:"TUpdateNewEncryptedMessage",
        content:"TUpdateNewEncryptedMessage",
        description:'',
        tags:''
    });

    a({
        id:72,
        title:"TPaymentVerficationNeeded",
        content:"TPaymentVerficationNeeded",
        description:'',
        tags:''
    });

    a({
        id:73,
        title:"RequestImportChatInvite",
        content:"RequestImportChatInvite",
        description:'',
        tags:''
    });

    a({
        id:74,
        title:"TChannelAdminLogEventActionChangeTitle",
        content:"TChannelAdminLogEventActionChangeTitle",
        description:'',
        tags:''
    });

    a({
        id:75,
        title:"IExportedChatInvite",
        content:"IExportedChatInvite",
        description:'',
        tags:''
    });

    a({
        id:76,
        title:"TInputPhoneContact",
        content:"TInputPhoneContact",
        description:'',
        tags:''
    });

    a({
        id:77,
        title:"IInputSingleMedia",
        content:"IInputSingleMedia",
        description:'',
        tags:''
    });

    a({
        id:78,
        title:"TInputFileBig",
        content:"TInputFileBig",
        description:'',
        tags:''
    });

    a({
        id:79,
        title:"RequestCheckChatInvite",
        content:"RequestCheckChatInvite",
        description:'',
        tags:''
    });

    a({
        id:80,
        title:"TTopPeer",
        content:"TTopPeer",
        description:'',
        tags:''
    });

    a({
        id:81,
        title:"TPageBlockPullquote",
        content:"TPageBlockPullquote",
        description:'',
        tags:''
    });

    a({
        id:82,
        title:"IPrivacyRules",
        content:"IPrivacyRules",
        description:'',
        tags:''
    });

    a({
        id:83,
        title:"IPaymentRequestedInfo",
        content:"IPaymentRequestedInfo",
        description:'',
        tags:''
    });

    a({
        id:84,
        title:"TPageBlockChannel",
        content:"TPageBlockChannel",
        description:'',
        tags:''
    });

    a({
        id:85,
        title:"TChannelAdminLogEvent",
        content:"TChannelAdminLogEvent",
        description:'',
        tags:''
    });

    a({
        id:86,
        title:"RequestReqPq",
        content:"RequestReqPq",
        description:'',
        tags:''
    });

    a({
        id:87,
        title:"TDhConfig",
        content:"TDhConfig",
        description:'',
        tags:''
    });

    a({
        id:88,
        title:"TInputEncryptedChat",
        content:"TInputEncryptedChat",
        description:'',
        tags:''
    });

    a({
        id:89,
        title:"IBotInlineResult",
        content:"IBotInlineResult",
        description:'',
        tags:''
    });

    a({
        id:90,
        title:"TServerDHParamsFail",
        content:"TServerDHParamsFail",
        description:'',
        tags:''
    });

    a({
        id:91,
        title:"TUpdateDcOptions",
        content:"TUpdateDcOptions",
        description:'',
        tags:''
    });

    a({
        id:92,
        title:"TTextUrl",
        content:"TTextUrl",
        description:'',
        tags:''
    });

    a({
        id:93,
        title:"RequestResetNotifySettings",
        content:"RequestResetNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:94,
        title:"RequestAcceptEncryption",
        content:"RequestAcceptEncryption",
        description:'',
        tags:''
    });

    a({
        id:95,
        title:"ITmpPassword",
        content:"ITmpPassword",
        description:'',
        tags:''
    });

    a({
        id:96,
        title:"TAllStickers",
        content:"TAllStickers",
        description:'',
        tags:''
    });

    a({
        id:97,
        title:"IConfig",
        content:"IConfig",
        description:'',
        tags:''
    });

    a({
        id:98,
        title:"TUpdatePinnedDialogs",
        content:"TUpdatePinnedDialogs",
        description:'',
        tags:''
    });

    a({
        id:99,
        title:"IEncryptedFile",
        content:"IEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:100,
        title:"TUpdateShort",
        content:"TUpdateShort",
        description:'',
        tags:''
    });

    a({
        id:101,
        title:"TInputPrivacyKeyPhoneCall",
        content:"TInputPrivacyKeyPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:102,
        title:"RequestUpdateDeviceLocked",
        content:"RequestUpdateDeviceLocked",
        description:'',
        tags:''
    });

    a({
        id:103,
        title:"TUpdateBotWebhookJSONQuery",
        content:"TUpdateBotWebhookJSONQuery",
        description:'',
        tags:''
    });

    a({
        id:104,
        title:"TInputReportReasonSpam",
        content:"TInputReportReasonSpam",
        description:'',
        tags:''
    });

    a({
        id:105,
        title:"TPageBlockSubheader",
        content:"TPageBlockSubheader",
        description:'',
        tags:''
    });

    a({
        id:106,
        title:"TInputMessagesFilterVoice",
        content:"TInputMessagesFilterVoice",
        description:'',
        tags:''
    });

    a({
        id:107,
        title:"TMessageActionChatJoinedByLink",
        content:"TMessageActionChatJoinedByLink",
        description:'',
        tags:''
    });

    a({
        id:108,
        title:"RequestGetPinnedDialogs",
        content:"RequestGetPinnedDialogs",
        description:'',
        tags:''
    });

    a({
        id:109,
        title:"TServerDHInnerData",
        content:"TServerDHInnerData",
        description:'',
        tags:''
    });

    a({
        id:110,
        title:"TTextBold",
        content:"TTextBold",
        description:'',
        tags:''
    });

    a({
        id:111,
        title:"TInputNotifyPeer",
        content:"TInputNotifyPeer",
        description:'',
        tags:''
    });

    a({
        id:112,
        title:"RequestGetAuthorizations",
        content:"RequestGetAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:113,
        title:"IMessageActionCommon",
        content:"IMessageActionCommon",
        description:'',
        tags:''
    });

    a({
        id:114,
        title:"TInputMessagesFilterEmpty",
        content:"TInputMessagesFilterEmpty",
        description:'',
        tags:''
    });

    a({
        id:115,
        title:"TInputAppEvent",
        content:"TInputAppEvent",
        description:'',
        tags:''
    });

    a({
        id:116,
        title:"TTextFixed",
        content:"TTextFixed",
        description:'',
        tags:''
    });

    a({
        id:117,
        title:"TContactLinkContact",
        content:"TContactLinkContact",
        description:'',
        tags:''
    });

    a({
        id:118,
        title:"IDraftMessage",
        content:"IDraftMessage",
        description:'',
        tags:''
    });

    a({
        id:119,
        title:"TInputReportReasonOther",
        content:"TInputReportReasonOther",
        description:'',
        tags:''
    });

    a({
        id:120,
        title:"RequestGetNotifySettings",
        content:"RequestGetNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:121,
        title:"TInputDocumentEmpty",
        content:"TInputDocumentEmpty",
        description:'',
        tags:''
    });

    a({
        id:122,
        title:"TDocument",
        content:"TDocument",
        description:'',
        tags:''
    });

    a({
        id:123,
        title:"RequestReqDHParams",
        content:"RequestReqDHParams",
        description:'',
        tags:''
    });

    a({
        id:124,
        title:"IPeerSettings",
        content:"IPeerSettings",
        description:'',
        tags:''
    });

    a({
        id:125,
        title:"RequestJoinChannel",
        content:"RequestJoinChannel",
        description:'',
        tags:''
    });

    a({
        id:126,
        title:"TUpdateDraftMessage",
        content:"TUpdateDraftMessage",
        description:'',
        tags:''
    });

    a({
        id:127,
        title:"TDocumentAttributeHasStickers",
        content:"TDocumentAttributeHasStickers",
        description:'',
        tags:''
    });

    a({
        id:128,
        title:"IKeyboardButtonRow",
        content:"IKeyboardButtonRow",
        description:'',
        tags:''
    });

    a({
        id:129,
        title:"RequestGetFileHashes",
        content:"RequestGetFileHashes",
        description:'',
        tags:''
    });

    a({
        id:130,
        title:"IDestroySessionRes",
        content:"IDestroySessionRes",
        description:'',
        tags:''
    });

    a({
        id:131,
        title:"ISentEncryptedMessage",
        content:"ISentEncryptedMessage",
        description:'',
        tags:''
    });

    a({
        id:132,
        title:"RequestEditChatTitle",
        content:"RequestEditChatTitle",
        description:'',
        tags:''
    });

    a({
        id:133,
        title:"TInputMediaGeoPoint",
        content:"TInputMediaGeoPoint",
        description:'',
        tags:''
    });

    a({
        id:134,
        title:"RequestGetAdminLog",
        content:"RequestGetAdminLog",
        description:'',
        tags:''
    });

    a({
        id:135,
        title:"IStickerSetCovered",
        content:"IStickerSetCovered",
        description:'',
        tags:''
    });

    a({
        id:136,
        title:"TDataJSON",
        content:"TDataJSON",
        description:'',
        tags:''
    });

    a({
        id:137,
        title:"TInputBotInlineMessageMediaGeo",
        content:"TInputBotInlineMessageMediaGeo",
        description:'',
        tags:''
    });

    a({
        id:138,
        title:"TFavedStickers",
        content:"TFavedStickers",
        description:'',
        tags:''
    });

    a({
        id:139,
        title:"TChannelMessagesFilter",
        content:"TChannelMessagesFilter",
        description:'',
        tags:''
    });

    a({
        id:140,
        title:"TUpdateNewStickerSet",
        content:"TUpdateNewStickerSet",
        description:'',
        tags:''
    });

    a({
        id:141,
        title:"IPopularContact",
        content:"IPopularContact",
        description:'',
        tags:''
    });

    a({
        id:142,
        title:"TContactLinkNone",
        content:"TContactLinkNone",
        description:'',
        tags:''
    });

    a({
        id:143,
        title:"RequestDeleteContact",
        content:"RequestDeleteContact",
        description:'',
        tags:''
    });

    a({
        id:144,
        title:"TInputMediaGame",
        content:"TInputMediaGame",
        description:'',
        tags:''
    });

    a({
        id:145,
        title:"IInputNotifyPeer",
        content:"IInputNotifyPeer",
        description:'',
        tags:''
    });

    a({
        id:146,
        title:"TRsaPublicKey",
        content:"TRsaPublicKey",
        description:'',
        tags:''
    });

    a({
        id:147,
        title:"TPageBlockEmbed",
        content:"TPageBlockEmbed",
        description:'',
        tags:''
    });

    a({
        id:148,
        title:"RequestBlock",
        content:"RequestBlock",
        description:'',
        tags:''
    });

    a({
        id:149,
        title:"IInputWebFileLocation",
        content:"IInputWebFileLocation",
        description:'',
        tags:''
    });

    a({
        id:150,
        title:"TUpdateUserStatus",
        content:"TUpdateUserStatus",
        description:'',
        tags:''
    });

    a({
        id:151,
        title:"TSendMessageTypingAction",
        content:"TSendMessageTypingAction",
        description:'',
        tags:''
    });

    a({
        id:152,
        title:"IWebFile",
        content:"IWebFile",
        description:'',
        tags:''
    });

    a({
        id:153,
        title:"IUpdates",
        content:"IUpdates",
        description:'',
        tags:''
    });

    a({
        id:154,
        title:"TWebDocument",
        content:"TWebDocument",
        description:'',
        tags:''
    });

    a({
        id:155,
        title:"IChatPhoto",
        content:"IChatPhoto",
        description:'',
        tags:''
    });

    a({
        id:156,
        title:"TInputGeoPoint",
        content:"TInputGeoPoint",
        description:'',
        tags:''
    });

    a({
        id:157,
        title:"TChats",
        content:"TChats",
        description:'',
        tags:''
    });

    a({
        id:158,
        title:"ISavedInfo",
        content:"ISavedInfo",
        description:'',
        tags:''
    });

    a({
        id:159,
        title:"IAppUpdate",
        content:"IAppUpdate",
        description:'',
        tags:''
    });

    a({
        id:160,
        title:"RequestUpdatePasswordSettings",
        content:"RequestUpdatePasswordSettings",
        description:'',
        tags:''
    });

    a({
        id:161,
        title:"RequestGetPaymentForm",
        content:"RequestGetPaymentForm",
        description:'',
        tags:''
    });

    a({
        id:162,
        title:"TChannelParticipantCreator",
        content:"TChannelParticipantCreator",
        description:'',
        tags:''
    });

    a({
        id:163,
        title:"TUpdateBotPrecheckoutQuery",
        content:"TUpdateBotPrecheckoutQuery",
        description:'',
        tags:''
    });

    a({
        id:164,
        title:"TMessageEntityTextUrl",
        content:"TMessageEntityTextUrl",
        description:'',
        tags:''
    });

    a({
        id:165,
        title:"IPeer",
        content:"IPeer",
        description:'',
        tags:''
    });

    a({
        id:166,
        title:"RequestCreateChat",
        content:"RequestCreateChat",
        description:'',
        tags:''
    });

    a({
        id:167,
        title:"RequestGetContacts",
        content:"RequestGetContacts",
        description:'',
        tags:''
    });

    a({
        id:168,
        title:"TUpdateEncryptedMessagesRead",
        content:"TUpdateEncryptedMessagesRead",
        description:'',
        tags:''
    });

    a({
        id:169,
        title:"TUpdateEditChannelMessage",
        content:"TUpdateEditChannelMessage",
        description:'',
        tags:''
    });

    a({
        id:170,
        title:"TLangPackStringPluralized",
        content:"TLangPackStringPluralized",
        description:'',
        tags:''
    });

    a({
        id:171,
        title:"TChannelAdminLogEventActionUpdatePinned",
        content:"TChannelAdminLogEventActionUpdatePinned",
        description:'',
        tags:''
    });

    a({
        id:172,
        title:"RequestResetWebAuthorizations",
        content:"RequestResetWebAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:173,
        title:"TCheckedPhone",
        content:"TCheckedPhone",
        description:'',
        tags:''
    });

    a({
        id:174,
        title:"RequestReceivedMessages",
        content:"RequestReceivedMessages",
        description:'',
        tags:''
    });

    a({
        id:175,
        title:"IWebAuthorizations",
        content:"IWebAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:176,
        title:"TMessageEntityEmail",
        content:"TMessageEntityEmail",
        description:'',
        tags:''
    });

    a({
        id:177,
        title:"TChannelParticipantsKicked",
        content:"TChannelParticipantsKicked",
        description:'',
        tags:''
    });

    a({
        id:178,
        title:"IMessages",
        content:"IMessages",
        description:'',
        tags:''
    });

    a({
        id:179,
        title:"TPageBlockCollage",
        content:"TPageBlockCollage",
        description:'',
        tags:''
    });

    a({
        id:180,
        title:"RequestResendCode",
        content:"RequestResendCode",
        description:'',
        tags:''
    });

    a({
        id:181,
        title:"TChatParticipant",
        content:"TChatParticipant",
        description:'',
        tags:''
    });

    a({
        id:182,
        title:"TInputMessagesFilterMyMentions",
        content:"TInputMessagesFilterMyMentions",
        description:'',
        tags:''
    });

    a({
        id:183,
        title:"TInputChatUploadedPhoto",
        content:"TInputChatUploadedPhoto",
        description:'',
        tags:''
    });

    a({
        id:184,
        title:"TUpdateReadChannelOutbox",
        content:"TUpdateReadChannelOutbox",
        description:'',
        tags:''
    });

    a({
        id:185,
        title:"RequestSaveDeveloperInfo",
        content:"RequestSaveDeveloperInfo",
        description:'',
        tags:''
    });

    a({
        id:186,
        title:"RequestGetCdnFileHashes",
        content:"RequestGetCdnFileHashes",
        description:'',
        tags:''
    });

    a({
        id:187,
        title:"TInputEncryptedFileBigUploaded",
        content:"TInputEncryptedFileBigUploaded",
        description:'',
        tags:''
    });

    a({
        id:188,
        title:"TPhoneCallDiscardReasonBusy",
        content:"TPhoneCallDiscardReasonBusy",
        description:'',
        tags:''
    });

    a({
        id:189,
        title:"RequestResetSaved",
        content:"RequestResetSaved",
        description:'',
        tags:''
    });

    a({
        id:190,
        title:"RequestGetRecentLocations",
        content:"RequestGetRecentLocations",
        description:'',
        tags:''
    });

    a({
        id:191,
        title:"RequestGetDhConfig",
        content:"RequestGetDhConfig",
        description:'',
        tags:''
    });

    a({
        id:192,
        title:"RequestGetCallConfig",
        content:"RequestGetCallConfig",
        description:'',
        tags:''
    });

    a({
        id:193,
        title:"TUpdateInlineBotCallbackQuery",
        content:"TUpdateInlineBotCallbackQuery",
        description:'',
        tags:''
    });

    a({
        id:194,
        title:"RequestSendMessage",
        content:"RequestSendMessage",
        description:'',
        tags:''
    });

    a({
        id:195,
        title:"ILink",
        content:"ILink",
        description:'',
        tags:''
    });

    a({
        id:196,
        title:"TEncryptedFileEmpty",
        content:"TEncryptedFileEmpty",
        description:'',
        tags:''
    });

    a({
        id:197,
        title:"TInputPrivacyValueAllowContacts",
        content:"TInputPrivacyValueAllowContacts",
        description:'',
        tags:''
    });

    a({
        id:198,
        title:"TTextItalic",
        content:"TTextItalic",
        description:'',
        tags:''
    });

    a({
        id:199,
        title:"TPhoneCallAccepted",
        content:"TPhoneCallAccepted",
        description:'',
        tags:''
    });

    a({
        id:200,
        title:"RequestSignUp",
        content:"RequestSignUp",
        description:'',
        tags:''
    });

    a({
        id:201,
        title:"TInputBotInlineResultPhoto",
        content:"TInputBotInlineResultPhoto",
        description:'',
        tags:''
    });

    a({
        id:202,
        title:"IInputDialogPeer",
        content:"IInputDialogPeer",
        description:'',
        tags:''
    });

    a({
        id:203,
        title:"RequestGetAllDrafts",
        content:"RequestGetAllDrafts",
        description:'',
        tags:''
    });

    a({
        id:204,
        title:"TEncryptedChatRequested",
        content:"TEncryptedChatRequested",
        description:'',
        tags:''
    });

    a({
        id:205,
        title:"TPageBlockPhoto",
        content:"TPageBlockPhoto",
        description:'',
        tags:''
    });

    a({
        id:206,
        title:"RequestSetBotUpdatesStatus",
        content:"RequestSetBotUpdatesStatus",
        description:'',
        tags:''
    });

    a({
        id:207,
        title:"TMessageEntityMentionName",
        content:"TMessageEntityMentionName",
        description:'',
        tags:''
    });

    a({
        id:208,
        title:"TMsgResendReq",
        content:"TMsgResendReq",
        description:'',
        tags:''
    });

    a({
        id:209,
        title:"RequestReadHistory",
        content:"RequestReadHistory",
        description:'',
        tags:''
    });

    a({
        id:210,
        title:"TInputPaymentCredentialsSaved",
        content:"TInputPaymentCredentialsSaved",
        description:'',
        tags:''
    });

    a({
        id:211,
        title:"TMessageActionScreenshotTaken",
        content:"TMessageActionScreenshotTaken",
        description:'',
        tags:''
    });

    a({
        id:212,
        title:"IPaymentResult",
        content:"IPaymentResult",
        description:'',
        tags:''
    });

    a({
        id:213,
        title:"RequestConfirmPhone",
        content:"RequestConfirmPhone",
        description:'',
        tags:''
    });

    a({
        id:214,
        title:"TBoolFalse",
        content:"TBoolFalse",
        description:'',
        tags:''
    });

    a({
        id:215,
        title:"TChannelParticipantsNotModified",
        content:"TChannelParticipantsNotModified",
        description:'',
        tags:''
    });

    a({
        id:216,
        title:"IPrivacyRule",
        content:"IPrivacyRule",
        description:'',
        tags:''
    });

    a({
        id:217,
        title:"RequestForwardMessages",
        content:"RequestForwardMessages",
        description:'',
        tags:''
    });

    a({
        id:218,
        title:"TInputDocument",
        content:"TInputDocument",
        description:'',
        tags:''
    });

    a({
        id:219,
        title:"TPQInnerData",
        content:"TPQInnerData",
        description:'',
        tags:''
    });

    a({
        id:220,
        title:"IChats",
        content:"IChats",
        description:'',
        tags:''
    });

    a({
        id:221,
        title:"TUserStatusOffline",
        content:"TUserStatusOffline",
        description:'',
        tags:''
    });

    a({
        id:222,
        title:"RequestGetDialogs",
        content:"RequestGetDialogs",
        description:'',
        tags:''
    });

    a({
        id:223,
        title:"IMessageCommon",
        content:"IMessageCommon",
        description:'',
        tags:''
    });

    a({
        id:224,
        title:"ISupport",
        content:"ISupport",
        description:'',
        tags:''
    });

    a({
        id:225,
        title:"TUserEmpty",
        content:"TUserEmpty",
        description:'',
        tags:''
    });

    a({
        id:226,
        title:"TInputPeerChat",
        content:"TInputPeerChat",
        description:'',
        tags:''
    });

    a({
        id:227,
        title:"RequestGetMessages",
        content:"RequestGetMessages",
        description:'',
        tags:''
    });

    a({
        id:228,
        title:"RequestSendMultiMedia",
        content:"RequestSendMultiMedia",
        description:'',
        tags:''
    });

    a({
        id:229,
        title:"TInputMessagesFilterDocument",
        content:"TInputMessagesFilterDocument",
        description:'',
        tags:''
    });

    a({
        id:230,
        title:"TTermsOfService",
        content:"TTermsOfService",
        description:'',
        tags:''
    });

    a({
        id:231,
        title:"TPhoneCallDiscardReasonHangup",
        content:"TPhoneCallDiscardReasonHangup",
        description:'',
        tags:''
    });

    a({
        id:232,
        title:"RequestReportSpam",
        content:"RequestReportSpam",
        description:'',
        tags:''
    });

    a({
        id:233,
        title:"TMessageActionPhoneCall",
        content:"TMessageActionPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:234,
        title:"TInputMediaPhotoExternal",
        content:"TInputMediaPhotoExternal",
        description:'',
        tags:''
    });

    a({
        id:235,
        title:"TBotInlineMessageMediaAuto",
        content:"TBotInlineMessageMediaAuto",
        description:'',
        tags:''
    });

    a({
        id:236,
        title:"IInputEncryptedChat",
        content:"IInputEncryptedChat",
        description:'',
        tags:''
    });

    a({
        id:237,
        title:"RequestReadMessageContents",
        content:"RequestReadMessageContents",
        description:'',
        tags:''
    });

    a({
        id:238,
        title:"TChannelFull",
        content:"TChannelFull",
        description:'',
        tags:''
    });

    a({
        id:239,
        title:"TChannelParticipantsSearch",
        content:"TChannelParticipantsSearch",
        description:'',
        tags:''
    });

    a({
        id:240,
        title:"TMessageEntityPhone",
        content:"TMessageEntityPhone",
        description:'',
        tags:''
    });

    a({
        id:241,
        title:"TUpdateMessageID",
        content:"TUpdateMessageID",
        description:'',
        tags:''
    });

    a({
        id:242,
        title:"TPaymentCharge",
        content:"TPaymentCharge",
        description:'',
        tags:''
    });

    a({
        id:243,
        title:"ISentCodeType",
        content:"ISentCodeType",
        description:'',
        tags:''
    });

    a({
        id:244,
        title:"RequestDeleteMessages",
        content:"RequestDeleteMessages",
        description:'',
        tags:''
    });

    a({
        id:245,
        title:"IPaymentReceipt",
        content:"IPaymentReceipt",
        description:'',
        tags:''
    });

    a({
        id:246,
        title:"TChannelAdminLogEventActionParticipantToggleBan",
        content:"TChannelAdminLogEventActionParticipantToggleBan",
        description:'',
        tags:''
    });

    a({
        id:247,
        title:"TChannelParticipant",
        content:"TChannelParticipant",
        description:'',
        tags:''
    });

    a({
        id:248,
        title:"TInputMediaUploadedDocument",
        content:"TInputMediaUploadedDocument",
        description:'',
        tags:''
    });

    a({
        id:249,
        title:"ISavedGifs",
        content:"ISavedGifs",
        description:'',
        tags:''
    });

    a({
        id:250,
        title:"TChannelAdminLogEventActionChangePhoto",
        content:"TChannelAdminLogEventActionChangePhoto",
        description:'',
        tags:''
    });

    a({
        id:251,
        title:"TUpdateSavedGifs",
        content:"TUpdateSavedGifs",
        description:'',
        tags:''
    });

    a({
        id:252,
        title:"ICdnFile",
        content:"ICdnFile",
        description:'',
        tags:''
    });

    a({
        id:253,
        title:"IChannelParticipants",
        content:"IChannelParticipants",
        description:'',
        tags:''
    });

    a({
        id:254,
        title:"RequestDiscardCall",
        content:"RequestDiscardCall",
        description:'',
        tags:''
    });

    a({
        id:255,
        title:"IPhoneConnection",
        content:"IPhoneConnection",
        description:'',
        tags:''
    });

    a({
        id:256,
        title:"RequestImportContacts",
        content:"RequestImportContacts",
        description:'',
        tags:''
    });

    a({
        id:257,
        title:"RequestGetParticipants",
        content:"RequestGetParticipants",
        description:'',
        tags:''
    });

    a({
        id:258,
        title:"TMessageActionPinMessage",
        content:"TMessageActionPinMessage",
        description:'',
        tags:''
    });

    a({
        id:259,
        title:"RequestDiscardEncryption",
        content:"RequestDiscardEncryption",
        description:'',
        tags:''
    });

    a({
        id:260,
        title:"IUserStatus",
        content:"IUserStatus",
        description:'',
        tags:''
    });

    a({
        id:261,
        title:"IPhoneCallProtocol",
        content:"IPhoneCallProtocol",
        description:'',
        tags:''
    });

    a({
        id:262,
        title:"RequestUpdateUsername",
        content:"RequestUpdateUsername",
        description:'',
        tags:''
    });

    a({
        id:263,
        title:"RequestSendCustomRequest",
        content:"RequestSendCustomRequest",
        description:'',
        tags:''
    });

    a({
        id:264,
        title:"TResolvedPeer",
        content:"TResolvedPeer",
        description:'',
        tags:''
    });

    a({
        id:265,
        title:"TUpdateChannel",
        content:"TUpdateChannel",
        description:'',
        tags:''
    });

    a({
        id:266,
        title:"TInputNotifyChats",
        content:"TInputNotifyChats",
        description:'',
        tags:''
    });

    a({
        id:267,
        title:"TInputMediaUploadedPhoto",
        content:"TInputMediaUploadedPhoto",
        description:'',
        tags:''
    });

    a({
        id:268,
        title:"NettyExtensions",
        content:"NettyExtensions",
        description:'',
        tags:''
    });

    a({
        id:269,
        title:"TNull",
        content:"TNull",
        description:'',
        tags:''
    });

    a({
        id:270,
        title:"TPageBlockCover",
        content:"TPageBlockCover",
        description:'',
        tags:''
    });

    a({
        id:271,
        title:"TChatInviteAlready",
        content:"TChatInviteAlready",
        description:'',
        tags:''
    });

    a({
        id:272,
        title:"IChatFull",
        content:"IChatFull",
        description:'',
        tags:''
    });

    a({
        id:273,
        title:"TPhoneCallRequested",
        content:"TPhoneCallRequested",
        description:'',
        tags:''
    });

    a({
        id:274,
        title:"RequestReportSpam",
        content:"RequestReportSpam",
        description:'',
        tags:''
    });

    a({
        id:275,
        title:"TRecentMeUrlStickerSet",
        content:"TRecentMeUrlStickerSet",
        description:'',
        tags:''
    });

    a({
        id:276,
        title:"IInputPeer",
        content:"IInputPeer",
        description:'',
        tags:''
    });

    a({
        id:277,
        title:"TInputGameID",
        content:"TInputGameID",
        description:'',
        tags:''
    });

    a({
        id:278,
        title:"TFoundGif",
        content:"TFoundGif",
        description:'',
        tags:''
    });

    a({
        id:279,
        title:"TInputReportReasonViolence",
        content:"TInputReportReasonViolence",
        description:'',
        tags:''
    });

    a({
        id:280,
        title:"IFoundGif",
        content:"IFoundGif",
        description:'',
        tags:''
    });

    a({
        id:281,
        title:"TUpdateChannelWebPage",
        content:"TUpdateChannelWebPage",
        description:'',
        tags:''
    });

    a({
        id:282,
        title:"IMsgDetailedInfo",
        content:"IMsgDetailedInfo",
        description:'',
        tags:''
    });

    a({
        id:283,
        title:"TInputPeerEmpty",
        content:"TInputPeerEmpty",
        description:'',
        tags:''
    });

    a({
        id:284,
        title:"IPong",
        content:"IPong",
        description:'',
        tags:''
    });

    a({
        id:285,
        title:"RequestSaveGif",
        content:"RequestSaveGif",
        description:'',
        tags:''
    });

    a({
        id:286,
        title:"IBadMsgNotification",
        content:"IBadMsgNotification",
        description:'',
        tags:''
    });

    a({
        id:287,
        title:"TKeyboardButtonBuy",
        content:"TKeyboardButtonBuy",
        description:'',
        tags:''
    });

    a({
        id:288,
        title:"TInputPaymentCredentials",
        content:"TInputPaymentCredentials",
        description:'',
        tags:''
    });

    a({
        id:289,
        title:"RequestEditInlineBotMessage",
        content:"RequestEditInlineBotMessage",
        description:'',
        tags:''
    });

    a({
        id:290,
        title:"TFileGif",
        content:"TFileGif",
        description:'',
        tags:''
    });

    a({
        id:291,
        title:"TInviteText",
        content:"TInviteText",
        description:'',
        tags:''
    });

    a({
        id:292,
        title:"TBotInlineResult",
        content:"TBotInlineResult",
        description:'',
        tags:''
    });

    a({
        id:293,
        title:"ISentCode",
        content:"ISentCode",
        description:'',
        tags:''
    });

    a({
        id:294,
        title:"TTopPeerCategoryPhoneCalls",
        content:"TTopPeerCategoryPhoneCalls",
        description:'',
        tags:''
    });

    a({
        id:295,
        title:"IStickerSetInstallResult",
        content:"IStickerSetInstallResult",
        description:'',
        tags:''
    });

    a({
        id:296,
        title:"RequestRecoverPassword",
        content:"RequestRecoverPassword",
        description:'',
        tags:''
    });

    a({
        id:297,
        title:"TChannelParticipants",
        content:"TChannelParticipants",
        description:'',
        tags:''
    });

    a({
        id:298,
        title:"TPrivacyValueAllowAll",
        content:"TPrivacyValueAllowAll",
        description:'',
        tags:''
    });

    a({
        id:299,
        title:"TChatPhotoEmpty",
        content:"TChatPhotoEmpty",
        description:'',
        tags:''
    });

    a({
        id:300,
        title:"TSendMessageChooseContactAction",
        content:"TSendMessageChooseContactAction",
        description:'',
        tags:''
    });

    a({
        id:301,
        title:"TEncryptedFile",
        content:"TEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:302,
        title:"TMsgsStateReq",
        content:"TMsgsStateReq",
        description:'',
        tags:''
    });

    a({
        id:303,
        title:"IUpdate",
        content:"IUpdate",
        description:'',
        tags:''
    });

    a({
        id:304,
        title:"TStickerSetMultiCovered",
        content:"TStickerSetMultiCovered",
        description:'',
        tags:''
    });

    a({
        id:305,
        title:"TInputGameShortName",
        content:"TInputGameShortName",
        description:'',
        tags:''
    });

    a({
        id:306,
        title:"TInputMessagesFilterPhotoVideo",
        content:"TInputMessagesFilterPhotoVideo",
        description:'',
        tags:''
    });

    a({
        id:307,
        title:"RequestGetMessages",
        content:"RequestGetMessages",
        description:'',
        tags:''
    });

    a({
        id:308,
        title:"RequestToggleDialogPin",
        content:"RequestToggleDialogPin",
        description:'',
        tags:''
    });

    a({
        id:309,
        title:"TMessageService",
        content:"TMessageService",
        description:'',
        tags:''
    });

    a({
        id:310,
        title:"ITopPeer",
        content:"ITopPeer",
        description:'',
        tags:''
    });

    a({
        id:311,
        title:"IStickerSet",
        content:"IStickerSet",
        description:'',
        tags:''
    });

    a({
        id:312,
        title:"RequestSetClientDHParams",
        content:"RequestSetClientDHParams",
        description:'',
        tags:''
    });

    a({
        id:313,
        title:"TTextStrike",
        content:"TTextStrike",
        description:'',
        tags:''
    });

    a({
        id:314,
        title:"RequestGetPassword",
        content:"RequestGetPassword",
        description:'',
        tags:''
    });

    a({
        id:315,
        title:"TSavedInfo",
        content:"TSavedInfo",
        description:'',
        tags:''
    });

    a({
        id:316,
        title:"RequestGetState",
        content:"RequestGetState",
        description:'',
        tags:''
    });

    a({
        id:317,
        title:"TDifferenceEmpty",
        content:"TDifferenceEmpty",
        description:'',
        tags:''
    });

    a({
        id:318,
        title:"RequestResetWebAuthorization",
        content:"RequestResetWebAuthorization",
        description:'',
        tags:''
    });

    a({
        id:319,
        title:"IChatFull",
        content:"IChatFull",
        description:'',
        tags:''
    });

    a({
        id:320,
        title:"TMessage",
        content:"TMessage",
        description:'',
        tags:''
    });

    a({
        id:321,
        title:"TFavedStickersNotModified",
        content:"TFavedStickersNotModified",
        description:'',
        tags:''
    });

    a({
        id:322,
        title:"RequestGetAccountTTL",
        content:"RequestGetAccountTTL",
        description:'',
        tags:''
    });

    a({
        id:323,
        title:"RequestImportAuthorization",
        content:"RequestImportAuthorization",
        description:'',
        tags:''
    });

    a({
        id:324,
        title:"TChat",
        content:"TChat",
        description:'',
        tags:''
    });

    a({
        id:325,
        title:"TAdminLogResults",
        content:"TAdminLogResults",
        description:'',
        tags:''
    });

    a({
        id:326,
        title:"TChatFull",
        content:"TChatFull",
        description:'',
        tags:''
    });

    a({
        id:327,
        title:"RequestImportCard",
        content:"RequestImportCard",
        description:'',
        tags:''
    });

    a({
        id:328,
        title:"TRecentMeUrlUnknown",
        content:"TRecentMeUrlUnknown",
        description:'',
        tags:''
    });

    a({
        id:329,
        title:"RequestInstallStickerSet",
        content:"RequestInstallStickerSet",
        description:'',
        tags:''
    });

    a({
        id:330,
        title:"IInputPhoneCall",
        content:"IInputPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:331,
        title:"IState",
        content:"IState",
        description:'',
        tags:''
    });

    a({
        id:332,
        title:"IInputEncryptedFile",
        content:"IInputEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:333,
        title:"RequestSendCode",
        content:"RequestSendCode",
        description:'',
        tags:''
    });

    a({
        id:334,
        title:"IChannelBannedRights",
        content:"IChannelBannedRights",
        description:'',
        tags:''
    });

    a({
        id:335,
        title:"RequestDeletePhotos",
        content:"RequestDeletePhotos",
        description:'',
        tags:''
    });

    a({
        id:336,
        title:"TMessageActionChatDeleteUser",
        content:"TMessageActionChatDeleteUser",
        description:'',
        tags:''
    });

    a({
        id:337,
        title:"TWallPaperSolid",
        content:"TWallPaperSolid",
        description:'',
        tags:''
    });

    a({
        id:338,
        title:"THighScores",
        content:"THighScores",
        description:'',
        tags:''
    });

    a({
        id:339,
        title:"Serializer",
        content:"Serializer",
        description:'',
        tags:''
    });

    a({
        id:340,
        title:"TRecentMeUrlChat",
        content:"TRecentMeUrlChat",
        description:'',
        tags:''
    });

    a({
        id:341,
        title:"TMessagesNotModified",
        content:"TMessagesNotModified",
        description:'',
        tags:''
    });

    a({
        id:342,
        title:"RequestSetCallRating",
        content:"RequestSetCallRating",
        description:'',
        tags:''
    });

    a({
        id:343,
        title:"RequestSaveDraft",
        content:"RequestSaveDraft",
        description:'',
        tags:''
    });

    a({
        id:344,
        title:"TMessageActionChannelCreate",
        content:"TMessageActionChannelCreate",
        description:'',
        tags:''
    });

    a({
        id:345,
        title:"TPrivacyValueAllowContacts",
        content:"TPrivacyValueAllowContacts",
        description:'',
        tags:''
    });

    a({
        id:346,
        title:"RequestToggleSignatures",
        content:"RequestToggleSignatures",
        description:'',
        tags:''
    });

    a({
        id:347,
        title:"IChatInvite",
        content:"IChatInvite",
        description:'',
        tags:''
    });

    a({
        id:348,
        title:"IFoundGifs",
        content:"IFoundGifs",
        description:'',
        tags:''
    });

    a({
        id:349,
        title:"RequestInvokeAfterMsgs",
        content:"RequestInvokeAfterMsgs",
        description:'',
        tags:''
    });

    a({
        id:350,
        title:"IDialog",
        content:"IDialog",
        description:'',
        tags:''
    });

    a({
        id:351,
        title:"IBotCallbackAnswer",
        content:"IBotCallbackAnswer",
        description:'',
        tags:''
    });

    a({
        id:352,
        title:"ISetClientDHParamsAnswer",
        content:"ISetClientDHParamsAnswer",
        description:'',
        tags:''
    });

    a({
        id:353,
        title:"TPasswordRecovery",
        content:"TPasswordRecovery",
        description:'',
        tags:''
    });

    a({
        id:354,
        title:"TPageBlockBlockquote",
        content:"TPageBlockBlockquote",
        description:'',
        tags:''
    });

    a({
        id:355,
        title:"TPeerNotifyEventsEmpty",
        content:"TPeerNotifyEventsEmpty",
        description:'',
        tags:''
    });

    a({
        id:356,
        title:"TMsgContainer",
        content:"TMsgContainer",
        description:'',
        tags:''
    });

    a({
        id:357,
        title:"TBotInlineMessageMediaGeo",
        content:"TBotInlineMessageMediaGeo",
        description:'',
        tags:''
    });

    a({
        id:358,
        title:"TChannelAdminLogEventActionParticipantToggleAdmin",
        content:"TChannelAdminLogEventActionParticipantToggleAdmin",
        description:'',
        tags:''
    });

    a({
        id:359,
        title:"TCdnConfig",
        content:"TCdnConfig",
        description:'',
        tags:''
    });

    a({
        id:360,
        title:"TPong",
        content:"TPong",
        description:'',
        tags:''
    });

    a({
        id:361,
        title:"TInputMediaPhoto",
        content:"TInputMediaPhoto",
        description:'',
        tags:''
    });

    a({
        id:362,
        title:"IEncryptedChatCommon",
        content:"IEncryptedChatCommon",
        description:'',
        tags:''
    });

    a({
        id:363,
        title:"RequestInitConnection",
        content:"RequestInitConnection",
        description:'',
        tags:''
    });

    a({
        id:364,
        title:"TUpdateShortChatMessage",
        content:"TUpdateShortChatMessage",
        description:'',
        tags:''
    });

    a({
        id:365,
        title:"IAccountDaysTTL",
        content:"IAccountDaysTTL",
        description:'',
        tags:''
    });

    a({
        id:366,
        title:"TWebFile",
        content:"TWebFile",
        description:'',
        tags:''
    });

    a({
        id:367,
        title:"RequestGetParticipant",
        content:"RequestGetParticipant",
        description:'',
        tags:''
    });

    a({
        id:368,
        title:"RequestGetTmpPassword",
        content:"RequestGetTmpPassword",
        description:'',
        tags:''
    });

    a({
        id:369,
        title:"RequestEditMessage",
        content:"RequestEditMessage",
        description:'',
        tags:''
    });

    a({
        id:370,
        title:"ILabeledPrice",
        content:"ILabeledPrice",
        description:'',
        tags:''
    });

    a({
        id:371,
        title:"IPhoto",
        content:"IPhoto",
        description:'',
        tags:''
    });

    a({
        id:372,
        title:"TPostAddress",
        content:"TPostAddress",
        description:'',
        tags:''
    });

    a({
        id:373,
        title:"RequestRequestPasswordRecovery",
        content:"RequestRequestPasswordRecovery",
        description:'',
        tags:''
    });

    a({
        id:374,
        title:"TInputPeerSelf",
        content:"TInputPeerSelf",
        description:'',
        tags:''
    });

    a({
        id:375,
        title:"IInputPrivacyKey",
        content:"IInputPrivacyKey",
        description:'',
        tags:''
    });

    a({
        id:376,
        title:"TBotInlineMediaResult",
        content:"TBotInlineMediaResult",
        description:'',
        tags:''
    });

    a({
        id:377,
        title:"TPrivacyValueDisallowContacts",
        content:"TPrivacyValueDisallowContacts",
        description:'',
        tags:''
    });

    a({
        id:378,
        title:"IInputMessage",
        content:"IInputMessage",
        description:'',
        tags:''
    });

    a({
        id:379,
        title:"IBool",
        content:"IBool",
        description:'',
        tags:''
    });

    a({
        id:380,
        title:"THighScore",
        content:"THighScore",
        description:'',
        tags:''
    });

    a({
        id:381,
        title:"TInputStickeredMediaPhoto",
        content:"TInputStickeredMediaPhoto",
        description:'',
        tags:''
    });

    a({
        id:382,
        title:"TAppUpdate",
        content:"TAppUpdate",
        description:'',
        tags:''
    });

    a({
        id:383,
        title:"TChatParticipants",
        content:"TChatParticipants",
        description:'',
        tags:''
    });

    a({
        id:384,
        title:"RequestGetDifference",
        content:"RequestGetDifference",
        description:'',
        tags:''
    });

    a({
        id:385,
        title:"IInputPeerNotifySettings",
        content:"IInputPeerNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:386,
        title:"IWallPaper",
        content:"IWallPaper",
        description:'',
        tags:''
    });

    a({
        id:387,
        title:"TWebPageNotModified",
        content:"TWebPageNotModified",
        description:'',
        tags:''
    });

    a({
        id:388,
        title:"IDialogs",
        content:"IDialogs",
        description:'',
        tags:''
    });

    a({
        id:389,
        title:"TChatInviteExported",
        content:"TChatInviteExported",
        description:'',
        tags:''
    });

    a({
        id:390,
        title:"TUserStatusLastWeek",
        content:"TUserStatusLastWeek",
        description:'',
        tags:''
    });

    a({
        id:391,
        title:"TDestroyAuthKeyOk",
        content:"TDestroyAuthKeyOk",
        description:'',
        tags:''
    });

    a({
        id:392,
        title:"RequestAddChatUser",
        content:"RequestAddChatUser",
        description:'',
        tags:''
    });

    a({
        id:393,
        title:"TBotCallbackAnswer",
        content:"TBotCallbackAnswer",
        description:'',
        tags:''
    });

    a({
        id:394,
        title:"TUserFull",
        content:"TUserFull",
        description:'',
        tags:''
    });

    a({
        id:395,
        title:"TInputBotInlineResultGame",
        content:"TInputBotInlineResultGame",
        description:'',
        tags:''
    });

    a({
        id:396,
        title:"RequestGetInlineBotResults",
        content:"RequestGetInlineBotResults",
        description:'',
        tags:''
    });

    a({
        id:397,
        title:"TTextPlain",
        content:"TTextPlain",
        description:'',
        tags:''
    });

    a({
        id:398,
        title:"TChannelAdminLogEventActionToggleInvites",
        content:"TChannelAdminLogEventActionToggleInvites",
        description:'',
        tags:''
    });

    a({
        id:399,
        title:"TInputMediaEmpty",
        content:"TInputMediaEmpty",
        description:'',
        tags:''
    });

    a({
        id:400,
        title:"IInputWebDocument",
        content:"IInputWebDocument",
        description:'',
        tags:''
    });

    a({
        id:401,
        title:"RequestUnregisterDevice",
        content:"RequestUnregisterDevice",
        description:'',
        tags:''
    });

    a({
        id:402,
        title:"IPaymentSavedCredentials",
        content:"IPaymentSavedCredentials",
        description:'',
        tags:''
    });

    a({
        id:403,
        title:"IDialogPeer",
        content:"IDialogPeer",
        description:'',
        tags:''
    });

    a({
        id:404,
        title:"RequestGetPeerDialogs",
        content:"RequestGetPeerDialogs",
        description:'',
        tags:''
    });

    a({
        id:405,
        title:"TFutureSalts",
        content:"TFutureSalts",
        description:'',
        tags:''
    });

    a({
        id:406,
        title:"TUpdateUserTyping",
        content:"TUpdateUserTyping",
        description:'',
        tags:''
    });

    a({
        id:407,
        title:"RequestSetTyping",
        content:"RequestSetTyping",
        description:'',
        tags:''
    });

    a({
        id:408,
        title:"TAffectedHistory",
        content:"TAffectedHistory",
        description:'',
        tags:''
    });

    a({
        id:409,
        title:"TInputPrivacyKeyChatInvite",
        content:"TInputPrivacyKeyChatInvite",
        description:'',
        tags:''
    });

    a({
        id:410,
        title:"TPeerNotifySettingsEmpty",
        content:"TPeerNotifySettingsEmpty",
        description:'',
        tags:''
    });

    a({
        id:411,
        title:"RequestDropTempAuthKeys",
        content:"RequestDropTempAuthKeys",
        description:'',
        tags:''
    });

    a({
        id:412,
        title:"RequestReceivedQueue",
        content:"RequestReceivedQueue",
        description:'',
        tags:''
    });

    a({
        id:413,
        title:"TMessageEntityMention",
        content:"TMessageEntityMention",
        description:'',
        tags:''
    });

    a({
        id:414,
        title:"TDraftMessageEmpty",
        content:"TDraftMessageEmpty",
        description:'',
        tags:''
    });

    a({
        id:415,
        title:"RequestExportAuthorization",
        content:"RequestExportAuthorization",
        description:'',
        tags:''
    });

    a({
        id:416,
        title:"RequestReadMentions",
        content:"RequestReadMentions",
        description:'',
        tags:''
    });

    a({
        id:417,
        title:"TKeyboardButtonSwitchInline",
        content:"TKeyboardButtonSwitchInline",
        description:'',
        tags:''
    });

    a({
        id:418,
        title:"TAffectedMessages",
        content:"TAffectedMessages",
        description:'',
        tags:''
    });

    a({
        id:419,
        title:"RequestAddStickerToSet",
        content:"RequestAddStickerToSet",
        description:'',
        tags:''
    });

    a({
        id:420,
        title:"TInputMessagesFilterUrl",
        content:"TInputMessagesFilterUrl",
        description:'',
        tags:''
    });

    a({
        id:421,
        title:"TContactLinkHasPhone",
        content:"TContactLinkHasPhone",
        description:'',
        tags:''
    });

    a({
        id:422,
        title:"RequestDestroySession",
        content:"RequestDestroySession",
        description:'',
        tags:''
    });

    a({
        id:423,
        title:"RequestGetFullChat",
        content:"RequestGetFullChat",
        description:'',
        tags:''
    });

    a({
        id:424,
        title:"TUpdateUserName",
        content:"TUpdateUserName",
        description:'',
        tags:''
    });

    a({
        id:425,
        title:"RequestCreateStickerSet",
        content:"RequestCreateStickerSet",
        description:'',
        tags:''
    });

    a({
        id:426,
        title:"TUpdateBotInlineQuery",
        content:"TUpdateBotInlineQuery",
        description:'',
        tags:''
    });

    a({
        id:427,
        title:"RequestToggleInvites",
        content:"RequestToggleInvites",
        description:'',
        tags:''
    });

    a({
        id:428,
        title:"TFileMov",
        content:"TFileMov",
        description:'',
        tags:''
    });

    a({
        id:429,
        title:"TInputMediaGifExternal",
        content:"TInputMediaGifExternal",
        description:'',
        tags:''
    });

    a({
        id:430,
        title:"TPaymentRequestedInfo",
        content:"TPaymentRequestedInfo",
        description:'',
        tags:''
    });

    a({
        id:431,
        title:"RequestGetNearestDc",
        content:"RequestGetNearestDc",
        description:'',
        tags:''
    });

    a({
        id:432,
        title:"RequestEditAbout",
        content:"RequestEditAbout",
        description:'',
        tags:''
    });

    a({
        id:433,
        title:"TUpdateReadMessagesContents",
        content:"TUpdateReadMessagesContents",
        description:'',
        tags:''
    });

    a({
        id:434,
        title:"TUpdateChannelReadMessagesContents",
        content:"TUpdateChannelReadMessagesContents",
        description:'',
        tags:''
    });

    a({
        id:435,
        title:"TServerDHParamsOk",
        content:"TServerDHParamsOk",
        description:'',
        tags:''
    });

    a({
        id:436,
        title:"TKeyboardButtonRequestGeoLocation",
        content:"TKeyboardButtonRequestGeoLocation",
        description:'',
        tags:''
    });

    a({
        id:437,
        title:"TMessageActionChannelMigrateFrom",
        content:"TMessageActionChannelMigrateFrom",
        description:'',
        tags:''
    });

    a({
        id:438,
        title:"RequestReadEncryptedHistory",
        content:"RequestReadEncryptedHistory",
        description:'',
        tags:''
    });

    a({
        id:439,
        title:"RequestGetDifference",
        content:"RequestGetDifference",
        description:'',
        tags:''
    });

    a({
        id:440,
        title:"RequestGetAppChangelog",
        content:"RequestGetAppChangelog",
        description:'',
        tags:''
    });

    a({
        id:441,
        title:"RequestEditAdmin",
        content:"RequestEditAdmin",
        description:'',
        tags:''
    });

    a({
        id:442,
        title:"TDocumentAttributeSticker",
        content:"TDocumentAttributeSticker",
        description:'',
        tags:''
    });

    a({
        id:443,
        title:"RequestDeleteContacts",
        content:"RequestDeleteContacts",
        description:'',
        tags:''
    });

    a({
        id:444,
        title:"TFeaturedStickers",
        content:"TFeaturedStickers",
        description:'',
        tags:''
    });

    a({
        id:445,
        title:"RequestGetWebAuthorizations",
        content:"RequestGetWebAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:446,
        title:"RequestBindTempAuthKey",
        content:"RequestBindTempAuthKey",
        description:'',
        tags:''
    });

    a({
        id:447,
        title:"TFound",
        content:"TFound",
        description:'',
        tags:''
    });

    a({
        id:448,
        title:"RequestExportInvite",
        content:"RequestExportInvite",
        description:'',
        tags:''
    });

    a({
        id:449,
        title:"TgZipPacked",
        content:"TgZipPacked",
        description:'',
        tags:''
    });

    a({
        id:450,
        title:"RequestGetMessagesViews",
        content:"RequestGetMessagesViews",
        description:'',
        tags:''
    });

    a({
        id:451,
        title:"TKeyboardButton",
        content:"TKeyboardButton",
        description:'',
        tags:''
    });

    a({
        id:452,
        title:"TBadServerSalt",
        content:"TBadServerSalt",
        description:'',
        tags:''
    });

    a({
        id:453,
        title:"TPeerNotifySettings",
        content:"TPeerNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:454,
        title:"TChannelParticipantAdmin",
        content:"TChannelParticipantAdmin",
        description:'',
        tags:''
    });

    a({
        id:455,
        title:"IChannelAdminLogEventAction",
        content:"IChannelAdminLogEventAction",
        description:'',
        tags:''
    });

    a({
        id:456,
        title:"TCodeTypeCall",
        content:"TCodeTypeCall",
        description:'',
        tags:''
    });

    a({
        id:457,
        title:"IChannelDifferenceCommon",
        content:"IChannelDifferenceCommon",
        description:'',
        tags:''
    });

    a({
        id:458,
        title:"IPeerDialogs",
        content:"IPeerDialogs",
        description:'',
        tags:''
    });

    a({
        id:459,
        title:"RequestRequestEncryption",
        content:"RequestRequestEncryption",
        description:'',
        tags:''
    });

    a({
        id:460,
        title:"IPrivacyKey",
        content:"IPrivacyKey",
        description:'',
        tags:''
    });

    a({
        id:461,
        title:"TFile",
        content:"TFile",
        description:'',
        tags:''
    });

    a({
        id:462,
        title:"TMessageEntityBotCommand",
        content:"TMessageEntityBotCommand",
        description:'',
        tags:''
    });

    a({
        id:463,
        title:"IInputEncryptedFileCommon",
        content:"IInputEncryptedFileCommon",
        description:'',
        tags:''
    });

    a({
        id:464,
        title:"TMessageActionChatMigrateTo",
        content:"TMessageActionChatMigrateTo",
        description:'',
        tags:''
    });

    a({
        id:465,
        title:"RequestGetGameHighScores",
        content:"RequestGetGameHighScores",
        description:'',
        tags:''
    });

    a({
        id:466,
        title:"TSavedGifsNotModified",
        content:"TSavedGifsNotModified",
        description:'',
        tags:''
    });

    a({
        id:467,
        title:"TMessageEntityCashtag",
        content:"TMessageEntityCashtag",
        description:'',
        tags:''
    });

    a({
        id:468,
        title:"RequestFaveSticker",
        content:"RequestFaveSticker",
        description:'',
        tags:''
    });

    a({
        id:469,
        title:"TMessageActionHistoryClear",
        content:"TMessageActionHistoryClear",
        description:'',
        tags:''
    });

    a({
        id:470,
        title:"RequestGetRecentStickers",
        content:"RequestGetRecentStickers",
        description:'',
        tags:''
    });

    a({
        id:471,
        title:"IMessageEditData",
        content:"IMessageEditData",
        description:'',
        tags:''
    });

    a({
        id:472,
        title:"RequestGetHistory",
        content:"RequestGetHistory",
        description:'',
        tags:''
    });

    a({
        id:473,
        title:"TSupport",
        content:"TSupport",
        description:'',
        tags:''
    });

    a({
        id:474,
        title:"TUpdateBotInlineSend",
        content:"TUpdateBotInlineSend",
        description:'',
        tags:''
    });

    a({
        id:475,
        title:"IDifference",
        content:"IDifference",
        description:'',
        tags:''
    });

    a({
        id:476,
        title:"IRpcDropAnswer",
        content:"IRpcDropAnswer",
        description:'',
        tags:''
    });

    a({
        id:477,
        title:"IInputChatPhoto",
        content:"IInputChatPhoto",
        description:'',
        tags:''
    });

    a({
        id:478,
        title:"RequestReportPeer",
        content:"RequestReportPeer",
        description:'',
        tags:''
    });

    a({
        id:479,
        title:"IPhoneCall",
        content:"IPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:480,
        title:"TMessageActionChatDeletePhoto",
        content:"TMessageActionChatDeletePhoto",
        description:'',
        tags:''
    });

    a({
        id:481,
        title:"TDialogPeer",
        content:"TDialogPeer",
        description:'',
        tags:''
    });

    a({
        id:482,
        title:"IWebDocument",
        content:"IWebDocument",
        description:'',
        tags:''
    });

    a({
        id:483,
        title:"TPageBlockAuthorDate",
        content:"TPageBlockAuthorDate",
        description:'',
        tags:''
    });

    a({
        id:484,
        title:"RequestCheckPassword",
        content:"RequestCheckPassword",
        description:'',
        tags:''
    });

    a({
        id:485,
        title:"IGeoPoint",
        content:"IGeoPoint",
        description:'',
        tags:''
    });

    a({
        id:486,
        title:"IChatParticipants",
        content:"IChatParticipants",
        description:'',
        tags:''
    });

    a({
        id:487,
        title:"IArchivedStickers",
        content:"IArchivedStickers",
        description:'',
        tags:''
    });

    a({
        id:488,
        title:"TDcOption",
        content:"TDcOption",
        description:'',
        tags:''
    });

    a({
        id:489,
        title:"TMessageActionPaymentSent",
        content:"TMessageActionPaymentSent",
        description:'',
        tags:''
    });

    a({
        id:490,
        title:"RequestReqPqMulti",
        content:"RequestReqPqMulti",
        description:'',
        tags:''
    });

    a({
        id:491,
        title:"IChannelAdminLogEvent",
        content:"IChannelAdminLogEvent",
        description:'',
        tags:''
    });

    a({
        id:492,
        title:"RequestReadHistory",
        content:"RequestReadHistory",
        description:'',
        tags:''
    });

    a({
        id:493,
        title:"RequestUninstallStickerSet",
        content:"RequestUninstallStickerSet",
        description:'',
        tags:''
    });

    a({
        id:494,
        title:"TTopPeerCategoryChannels",
        content:"TTopPeerCategoryChannels",
        description:'',
        tags:''
    });

    a({
        id:495,
        title:"RequestUpdateStatus",
        content:"RequestUpdateStatus",
        description:'',
        tags:''
    });

    a({
        id:496,
        title:"TBlocked",
        content:"TBlocked",
        description:'',
        tags:''
    });

    a({
        id:497,
        title:"TInputBotInlineResult",
        content:"TInputBotInlineResult",
        description:'',
        tags:''
    });

    a({
        id:498,
        title:"IPhotos",
        content:"IPhotos",
        description:'',
        tags:''
    });

    a({
        id:499,
        title:"TTopPeers",
        content:"TTopPeers",
        description:'',
        tags:''
    });

    a({
        id:500,
        title:"TPhotoSize",
        content:"TPhotoSize",
        description:'',
        tags:''
    });

    a({
        id:501,
        title:"IChatParticipant",
        content:"IChatParticipant",
        description:'',
        tags:''
    });

    a({
        id:502,
        title:"TIpPort",
        content:"TIpPort",
        description:'',
        tags:''
    });

    a({
        id:503,
        title:"IInputBotInlineMessageID",
        content:"IInputBotInlineMessageID",
        description:'',
        tags:''
    });

    a({
        id:504,
        title:"RequestSendInvites",
        content:"RequestSendInvites",
        description:'',
        tags:''
    });

    a({
        id:505,
        title:"TChannelAdminLogEventActionChangeAbout",
        content:"TChannelAdminLogEventActionChangeAbout",
        description:'',
        tags:''
    });

    a({
        id:506,
        title:"TInputMediaInvoice",
        content:"TInputMediaInvoice",
        description:'',
        tags:''
    });

    a({
        id:507,
        title:"TChannelAdminLogEventActionEditMessage",
        content:"TChannelAdminLogEventActionEditMessage",
        description:'',
        tags:''
    });

    a({
        id:508,
        title:"TSentCode",
        content:"TSentCode",
        description:'',
        tags:''
    });

    a({
        id:509,
        title:"TStickerSetCovered",
        content:"TStickerSetCovered",
        description:'',
        tags:''
    });

    a({
        id:510,
        title:"IPostAddress",
        content:"IPostAddress",
        description:'',
        tags:''
    });

    a({
        id:511,
        title:"TChannelAdminLogEventsFilter",
        content:"TChannelAdminLogEventsFilter",
        description:'',
        tags:''
    });

    a({
        id:512,
        title:"IInputStickeredMedia",
        content:"IInputStickeredMedia",
        description:'',
        tags:''
    });

    a({
        id:513,
        title:"IServerDHParams",
        content:"IServerDHParams",
        description:'',
        tags:''
    });

    a({
        id:514,
        title:"TUpdateEditMessage",
        content:"TUpdateEditMessage",
        description:'',
        tags:''
    });

    a({
        id:515,
        title:"IFavedStickers",
        content:"IFavedStickers",
        description:'',
        tags:''
    });

    a({
        id:516,
        title:"RequestSaveRecentSticker",
        content:"RequestSaveRecentSticker",
        description:'',
        tags:''
    });

    a({
        id:517,
        title:"RequestSetBotShippingResults",
        content:"RequestSetBotShippingResults",
        description:'',
        tags:''
    });

    a({
        id:518,
        title:"IInputMedia",
        content:"IInputMedia",
        description:'',
        tags:''
    });

    a({
        id:519,
        title:"TMsgDetailedInfo",
        content:"TMsgDetailedInfo",
        description:'',
        tags:''
    });

    a({
        id:520,
        title:"RequestEditChatPhoto",
        content:"RequestEditChatPhoto",
        description:'',
        tags:''
    });

    a({
        id:521,
        title:"TInlineBotSwitchPM",
        content:"TInlineBotSwitchPM",
        description:'',
        tags:''
    });

    a({
        id:522,
        title:"IWebAuthorization",
        content:"IWebAuthorization",
        description:'',
        tags:''
    });

    a({
        id:523,
        title:"RequestMigrateChat",
        content:"RequestMigrateChat",
        description:'',
        tags:''
    });

    a({
        id:524,
        title:"RequestGetWebPage",
        content:"RequestGetWebPage",
        description:'',
        tags:''
    });

    a({
        id:525,
        title:"TCdnPublicKey",
        content:"TCdnPublicKey",
        description:'',
        tags:''
    });

    a({
        id:526,
        title:"IChannelAdminLogEventsFilter",
        content:"IChannelAdminLogEventsFilter",
        description:'',
        tags:''
    });

    a({
        id:527,
        title:"TMessageEntityItalic",
        content:"TMessageEntityItalic",
        description:'',
        tags:''
    });

    a({
        id:528,
        title:"IFutureSalts",
        content:"IFutureSalts",
        description:'',
        tags:''
    });

    a({
        id:529,
        title:"TMessageActionChatCreate",
        content:"TMessageActionChatCreate",
        description:'',
        tags:''
    });

    a({
        id:530,
        title:"IMaskCoords",
        content:"IMaskCoords",
        description:'',
        tags:''
    });

    a({
        id:531,
        title:"TBoolTrue",
        content:"TBoolTrue",
        description:'',
        tags:''
    });

    a({
        id:532,
        title:"TContainerMessage",
        content:"TContainerMessage",
        description:'',
        tags:''
    });

    a({
        id:533,
        title:"TPrivacyKeyStatusTimestamp",
        content:"TPrivacyKeyStatusTimestamp",
        description:'',
        tags:''
    });

    a({
        id:534,
        title:"TInputMessagesFilterRoundVoice",
        content:"TInputMessagesFilterRoundVoice",
        description:'',
        tags:''
    });

    a({
        id:535,
        title:"IFeaturedStickers",
        content:"IFeaturedStickers",
        description:'',
        tags:''
    });

    a({
        id:536,
        title:"TInputUserEmpty",
        content:"TInputUserEmpty",
        description:'',
        tags:''
    });

    a({
        id:537,
        title:"TConfig",
        content:"TConfig",
        description:'',
        tags:''
    });

    a({
        id:538,
        title:"TPageBlockParagraph",
        content:"TPageBlockParagraph",
        description:'',
        tags:''
    });

    a({
        id:539,
        title:"TMsgsStateInfo",
        content:"TMsgsStateInfo",
        description:'',
        tags:''
    });

    a({
        id:540,
        title:"TInputPeerUser",
        content:"TInputPeerUser",
        description:'',
        tags:''
    });

    a({
        id:541,
        title:"TUpdateChatParticipants",
        content:"TUpdateChatParticipants",
        description:'',
        tags:''
    });

    a({
        id:542,
        title:"IReportReason",
        content:"IReportReason",
        description:'',
        tags:''
    });

    a({
        id:543,
        title:"TUpdateChannelTooLong",
        content:"TUpdateChannelTooLong",
        description:'',
        tags:''
    });

    a({
        id:544,
        title:"TStickerPack",
        content:"TStickerPack",
        description:'',
        tags:''
    });

    a({
        id:545,
        title:"RequestConfirmCall",
        content:"RequestConfirmCall",
        description:'',
        tags:''
    });

    a({
        id:546,
        title:"TInputEncryptedFileLocation",
        content:"TInputEncryptedFileLocation",
        description:'',
        tags:''
    });

    a({
        id:547,
        title:"RequestSetBotPrecheckoutResults",
        content:"RequestSetBotPrecheckoutResults",
        description:'',
        tags:''
    });

    a({
        id:548,
        title:"TTextEmpty",
        content:"TTextEmpty",
        description:'',
        tags:''
    });

    a({
        id:549,
        title:"TPasswordSettings",
        content:"TPasswordSettings",
        description:'',
        tags:''
    });

    a({
        id:550,
        title:"TInputMessageEntityMentionName",
        content:"TInputMessageEntityMentionName",
        description:'',
        tags:''
    });

    a({
        id:551,
        title:"ICheckedPhone",
        content:"ICheckedPhone",
        description:'',
        tags:''
    });

    a({
        id:552,
        title:"TRpcAnswerUnknown",
        content:"TRpcAnswerUnknown",
        description:'',
        tags:''
    });

    a({
        id:553,
        title:"IInputPeerNotifyEvents",
        content:"IInputPeerNotifyEvents",
        description:'',
        tags:''
    });

    a({
        id:554,
        title:"TInputBotInlineMessageMediaVenue",
        content:"TInputBotInlineMessageMediaVenue",
        description:'',
        tags:''
    });

    a({
        id:555,
        title:"RequestSendInlineBotResult",
        content:"RequestSendInlineBotResult",
        description:'',
        tags:''
    });

    a({
        id:556,
        title:"IMessage",
        content:"IMessage",
        description:'',
        tags:''
    });

    a({
        id:557,
        title:"RequestExportChatInvite",
        content:"RequestExportChatInvite",
        description:'',
        tags:''
    });

    a({
        id:558,
        title:"IPageBlock",
        content:"IPageBlock",
        description:'',
        tags:''
    });

    a({
        id:559,
        title:"ISendMessageAction",
        content:"ISendMessageAction",
        description:'',
        tags:''
    });

    a({
        id:560,
        title:"TUserStatusLastMonth",
        content:"TUserStatusLastMonth",
        description:'',
        tags:''
    });

    a({
        id:561,
        title:"TUserProfilePhoto",
        content:"TUserProfilePhoto",
        description:'',
        tags:''
    });

    a({
        id:562,
        title:"TInputMessagesFilterContacts",
        content:"TInputMessagesFilterContacts",
        description:'',
        tags:''
    });

    a({
        id:563,
        title:"TChatFull",
        content:"TChatFull",
        description:'',
        tags:''
    });

    a({
        id:564,
        title:"TInputEncryptedFileEmpty",
        content:"TInputEncryptedFileEmpty",
        description:'',
        tags:''
    });

    a({
        id:565,
        title:"RequestEditChatAdmin",
        content:"RequestEditChatAdmin",
        description:'',
        tags:''
    });

    a({
        id:566,
        title:"IMessagesFilter",
        content:"IMessagesFilter",
        description:'',
        tags:''
    });

    a({
        id:567,
        title:"BareTypeAttribute",
        content:"BareTypeAttribute",
        description:'',
        tags:''
    });

    a({
        id:568,
        title:"RequestDeleteMessages",
        content:"RequestDeleteMessages",
        description:'',
        tags:''
    });

    a({
        id:569,
        title:"RequestDeleteAccount",
        content:"RequestDeleteAccount",
        description:'',
        tags:''
    });

    a({
        id:570,
        title:"TInputMessagesFilterGif",
        content:"TInputMessagesFilterGif",
        description:'',
        tags:''
    });

    a({
        id:571,
        title:"RequestImportBotAuthorization",
        content:"RequestImportBotAuthorization",
        description:'',
        tags:''
    });

    a({
        id:572,
        title:"TUpdateDialogPinned",
        content:"TUpdateDialogPinned",
        description:'',
        tags:''
    });

    a({
        id:573,
        title:"IPhotoSize",
        content:"IPhotoSize",
        description:'',
        tags:''
    });

    a({
        id:574,
        title:"TPhotoEmpty",
        content:"TPhotoEmpty",
        description:'',
        tags:''
    });

    a({
        id:575,
        title:"RequestGetUsers",
        content:"RequestGetUsers",
        description:'',
        tags:''
    });

    a({
        id:576,
        title:"TMessageActionChatAddUser",
        content:"TMessageActionChatAddUser",
        description:'',
        tags:''
    });

    a({
        id:577,
        title:"IInputContact",
        content:"IInputContact",
        description:'',
        tags:''
    });

    a({
        id:578,
        title:"RequestSendConfirmPhoneCode",
        content:"RequestSendConfirmPhoneCode",
        description:'',
        tags:''
    });

    a({
        id:579,
        title:"TArchivedStickers",
        content:"TArchivedStickers",
        description:'',
        tags:''
    });

    a({
        id:580,
        title:"TBotInlineMessageMediaVenue",
        content:"TBotInlineMessageMediaVenue",
        description:'',
        tags:''
    });

    a({
        id:581,
        title:"IContact",
        content:"IContact",
        description:'',
        tags:''
    });

    a({
        id:582,
        title:"RequestGetUnreadMentions",
        content:"RequestGetUnreadMentions",
        description:'',
        tags:''
    });

    a({
        id:583,
        title:"TChannelParticipantsAdmins",
        content:"TChannelParticipantsAdmins",
        description:'',
        tags:''
    });

    a({
        id:584,
        title:"IAuthorization",
        content:"IAuthorization",
        description:'',
        tags:''
    });

    a({
        id:585,
        title:"TEncryptedMessageService",
        content:"TEncryptedMessageService",
        description:'',
        tags:''
    });

    a({
        id:586,
        title:"IInputPrivacyRule",
        content:"IInputPrivacyRule",
        description:'',
        tags:''
    });

    a({
        id:587,
        title:"TInputBotInlineMessageGame",
        content:"TInputBotInlineMessageGame",
        description:'',
        tags:''
    });

    a({
        id:588,
        title:"TInputNotifyUsers",
        content:"TInputNotifyUsers",
        description:'',
        tags:''
    });

    a({
        id:589,
        title:"TRpcResult",
        content:"TRpcResult",
        description:'',
        tags:''
    });

    a({
        id:590,
        title:"TDocumentAttributeFilename",
        content:"TDocumentAttributeFilename",
        description:'',
        tags:''
    });

    a({
        id:591,
        title:"TInputDocumentFileLocation",
        content:"TInputDocumentFileLocation",
        description:'',
        tags:''
    });

    a({
        id:592,
        title:"TTmpPassword",
        content:"TTmpPassword",
        description:'',
        tags:''
    });

    a({
        id:593,
        title:"RequestGetSupport",
        content:"RequestGetSupport",
        description:'',
        tags:''
    });

    a({
        id:594,
        title:"RequestGetSavedGifs",
        content:"RequestGetSavedGifs",
        description:'',
        tags:''
    });

    a({
        id:595,
        title:"TMessageMediaGeoLive",
        content:"TMessageMediaGeoLive",
        description:'',
        tags:''
    });

    a({
        id:596,
        title:"TFoundStickerSetsNotModified",
        content:"TFoundStickerSetsNotModified",
        description:'',
        tags:''
    });

    a({
        id:597,
        title:"TChannelAdminLogEventActionParticipantLeave",
        content:"TChannelAdminLogEventActionParticipantLeave",
        description:'',
        tags:''
    });

    a({
        id:598,
        title:"TChannelAdminLogEventActionChangeStickerSet",
        content:"TChannelAdminLogEventActionChangeStickerSet",
        description:'',
        tags:''
    });

    a({
        id:599,
        title:"TUpdatePtsChanged",
        content:"TUpdatePtsChanged",
        description:'',
        tags:''
    });

    a({
        id:600,
        title:"TUpdates",
        content:"TUpdates",
        description:'',
        tags:''
    });

    a({
        id:601,
        title:"TPageBlockSlideshow",
        content:"TPageBlockSlideshow",
        description:'',
        tags:''
    });

    a({
        id:602,
        title:"IInputDocument",
        content:"IInputDocument",
        description:'',
        tags:''
    });

    a({
        id:603,
        title:"RequestGetChannels",
        content:"RequestGetChannels",
        description:'',
        tags:''
    });

    a({
        id:604,
        title:"TUpdateEncryptedChatTyping",
        content:"TUpdateEncryptedChatTyping",
        description:'',
        tags:''
    });

    a({
        id:605,
        title:"RequestClearRecentStickers",
        content:"RequestClearRecentStickers",
        description:'',
        tags:''
    });

    a({
        id:606,
        title:"IStickers",
        content:"IStickers",
        description:'',
        tags:''
    });

    a({
        id:607,
        title:"TDocumentAttributeAudio",
        content:"TDocumentAttributeAudio",
        description:'',
        tags:''
    });

    a({
        id:608,
        title:"TUser",
        content:"TUser",
        description:'',
        tags:''
    });

    a({
        id:609,
        title:"TMessageMediaEmpty",
        content:"TMessageMediaEmpty",
        description:'',
        tags:''
    });

    a({
        id:610,
        title:"TPageFull",
        content:"TPageFull",
        description:'',
        tags:''
    });

    a({
        id:611,
        title:"TPrivacyKeyChatInvite",
        content:"TPrivacyKeyChatInvite",
        description:'',
        tags:''
    });

    a({
        id:612,
        title:"IFileType",
        content:"IFileType",
        description:'',
        tags:''
    });

    a({
        id:613,
        title:"TInputBotInlineResultDocument",
        content:"TInputBotInlineResultDocument",
        description:'',
        tags:''
    });

    a({
        id:614,
        title:"TWallPaper",
        content:"TWallPaper",
        description:'',
        tags:''
    });

    a({
        id:615,
        title:"RequestResetAuthorizations",
        content:"RequestResetAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:616,
        title:"TInputPrivacyValueDisallowAll",
        content:"TInputPrivacyValueDisallowAll",
        description:'',
        tags:''
    });

    a({
        id:617,
        title:"RequestGetBotCallbackAnswer",
        content:"RequestGetBotCallbackAnswer",
        description:'',
        tags:''
    });

    a({
        id:618,
        title:"TGeoPointEmpty",
        content:"TGeoPointEmpty",
        description:'',
        tags:''
    });

    a({
        id:619,
        title:"RequestExportMessageLink",
        content:"RequestExportMessageLink",
        description:'',
        tags:''
    });

    a({
        id:620,
        title:"TDifference",
        content:"TDifference",
        description:'',
        tags:''
    });

    a({
        id:621,
        title:"TUpdateBotShippingQuery",
        content:"TUpdateBotShippingQuery",
        description:'',
        tags:''
    });

    a({
        id:622,
        title:"IUserStatusCommon",
        content:"IUserStatusCommon",
        description:'',
        tags:''
    });

    a({
        id:623,
        title:"TInputUser",
        content:"TInputUser",
        description:'',
        tags:''
    });

    a({
        id:624,
        title:"TMessageRange",
        content:"TMessageRange",
        description:'',
        tags:''
    });

    a({
        id:625,
        title:"TFileWebp",
        content:"TFileWebp",
        description:'',
        tags:''
    });

    a({
        id:626,
        title:"IUserProfilePhoto",
        content:"IUserProfilePhoto",
        description:'',
        tags:''
    });

    a({
        id:627,
        title:"IDestroyAuthKeyRes",
        content:"IDestroyAuthKeyRes",
        description:'',
        tags:''
    });

    a({
        id:628,
        title:"RequestChangeStickerPosition",
        content:"RequestChangeStickerPosition",
        description:'',
        tags:''
    });

    a({
        id:629,
        title:"TFileMp",
        content:"TFileMp",
        description:'',
        tags:''
    });

    a({
        id:630,
        title:"IDocumentAttribute",
        content:"IDocumentAttribute",
        description:'',
        tags:''
    });

    a({
        id:631,
        title:"TChatsSlice",
        content:"TChatsSlice",
        description:'',
        tags:''
    });

    a({
        id:632,
        title:"TMessageMediaUnsupported",
        content:"TMessageMediaUnsupported",
        description:'',
        tags:''
    });

    a({
        id:633,
        title:"TInputDialogPeer",
        content:"TInputDialogPeer",
        description:'',
        tags:''
    });

    a({
        id:634,
        title:"IMessageMedia",
        content:"IMessageMedia",
        description:'',
        tags:''
    });

    a({
        id:635,
        title:"RequestGetStatuses",
        content:"RequestGetStatuses",
        description:'',
        tags:''
    });

    a({
        id:636,
        title:"IMessageAction",
        content:"IMessageAction",
        description:'',
        tags:''
    });

    a({
        id:637,
        title:"TSentCodeTypeSms",
        content:"TSentCodeTypeSms",
        description:'',
        tags:''
    });

    a({
        id:638,
        title:"TMessageActionBotAllowed",
        content:"TMessageActionBotAllowed",
        description:'',
        tags:''
    });

    a({
        id:639,
        title:"IKeyboardButton",
        content:"IKeyboardButton",
        description:'',
        tags:''
    });

    a({
        id:640,
        title:"IChatCommon",
        content:"IChatCommon",
        description:'',
        tags:''
    });

    a({
        id:641,
        title:"TFeaturedStickersNotModified",
        content:"TFeaturedStickersNotModified",
        description:'',
        tags:''
    });

    a({
        id:642,
        title:"TPageBlockSubtitle",
        content:"TPageBlockSubtitle",
        description:'',
        tags:''
    });

    a({
        id:643,
        title:"TBotInfo",
        content:"TBotInfo",
        description:'',
        tags:''
    });

    a({
        id:644,
        title:"RequestEditTitle",
        content:"RequestEditTitle",
        description:'',
        tags:''
    });

    a({
        id:645,
        title:"TInputSingleMedia",
        content:"TInputSingleMedia",
        description:'',
        tags:''
    });

    a({
        id:646,
        title:"RequestGetFile",
        content:"RequestGetFile",
        description:'',
        tags:''
    });

    a({
        id:647,
        title:"TShippingOption",
        content:"TShippingOption",
        description:'',
        tags:''
    });

    a({
        id:648,
        title:"TBotInlineMessageText",
        content:"TBotInlineMessageText",
        description:'',
        tags:''
    });

    a({
        id:649,
        title:"TSendMessageUploadRoundAction",
        content:"TSendMessageUploadRoundAction",
        description:'',
        tags:''
    });

    a({
        id:650,
        title:"TInputPeerNotifySettings",
        content:"TInputPeerNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:651,
        title:"TDhGenRetry",
        content:"TDhGenRetry",
        description:'',
        tags:''
    });

    a({
        id:652,
        title:"RequestGetArchivedStickers",
        content:"RequestGetArchivedStickers",
        description:'',
        tags:''
    });

    a({
        id:653,
        title:"TFileLocation",
        content:"TFileLocation",
        description:'',
        tags:''
    });

    a({
        id:654,
        title:"TSentEncryptedFile",
        content:"TSentEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:655,
        title:"TPageBlockAnchor",
        content:"TPageBlockAnchor",
        description:'',
        tags:''
    });

    a({
        id:656,
        title:"RequestToggleChatAdmins",
        content:"RequestToggleChatAdmins",
        description:'',
        tags:''
    });

    a({
        id:657,
        title:"TGame",
        content:"TGame",
        description:'',
        tags:''
    });

    a({
        id:658,
        title:"IFile",
        content:"IFile",
        description:'',
        tags:''
    });

    a({
        id:659,
        title:"TPeerNotifyEventsAll",
        content:"TPeerNotifyEventsAll",
        description:'',
        tags:''
    });

    a({
        id:660,
        title:"IEncryptedMessage",
        content:"IEncryptedMessage",
        description:'',
        tags:''
    });

    a({
        id:661,
        title:"IChannelParticipantsFilter",
        content:"IChannelParticipantsFilter",
        description:'',
        tags:''
    });

    a({
        id:662,
        title:"TBotResults",
        content:"TBotResults",
        description:'',
        tags:''
    });

    a({
        id:663,
        title:"RequestEditPhoto",
        content:"RequestEditPhoto",
        description:'',
        tags:''
    });

    a({
        id:664,
        title:"TMessageEmpty",
        content:"TMessageEmpty",
        description:'',
        tags:''
    });

    a({
        id:665,
        title:"TChannelParticipant",
        content:"TChannelParticipant",
        description:'',
        tags:''
    });

    a({
        id:666,
        title:"TInputBotInlineMessageID",
        content:"TInputBotInlineMessageID",
        description:'',
        tags:''
    });

    a({
        id:667,
        title:"TInputMediaDocumentExternal",
        content:"TInputMediaDocumentExternal",
        description:'',
        tags:''
    });

    a({
        id:668,
        title:"TSendMessageCancelAction",
        content:"TSendMessageCancelAction",
        description:'',
        tags:''
    });

    a({
        id:669,
        title:"RequestCheckPhone",
        content:"RequestCheckPhone",
        description:'',
        tags:''
    });

    a({
        id:670,
        title:"TTextConcat",
        content:"TTextConcat",
        description:'',
        tags:''
    });

    a({
        id:671,
        title:"TNotifyPeer",
        content:"TNotifyPeer",
        description:'',
        tags:''
    });

    a({
        id:672,
        title:"RequestGetInviteText",
        content:"RequestGetInviteText",
        description:'',
        tags:''
    });

    a({
        id:673,
        title:"TInputMessagesFilterGeo",
        content:"TInputMessagesFilterGeo",
        description:'',
        tags:''
    });

    a({
        id:674,
        title:"TFileLocationUnavailable",
        content:"TFileLocationUnavailable",
        description:'',
        tags:''
    });

    a({
        id:675,
        title:"TDocumentAttributeImageSize",
        content:"TDocumentAttributeImageSize",
        description:'',
        tags:''
    });

    a({
        id:676,
        title:"TNoPassword",
        content:"TNoPassword",
        description:'',
        tags:''
    });

    a({
        id:677,
        title:"IAffectedMessages",
        content:"IAffectedMessages",
        description:'',
        tags:''
    });

    a({
        id:678,
        title:"TDraftMessage",
        content:"TDraftMessage",
        description:'',
        tags:''
    });

    a({
        id:679,
        title:"TReplyKeyboardMarkup",
        content:"TReplyKeyboardMarkup",
        description:'',
        tags:''
    });

    a({
        id:680,
        title:"IInputGame",
        content:"IInputGame",
        description:'',
        tags:''
    });

    a({
        id:681,
        title:"IAllStickers",
        content:"IAllStickers",
        description:'',
        tags:''
    });

    a({
        id:682,
        title:"RequestGetPaymentReceipt",
        content:"RequestGetPaymentReceipt",
        description:'',
        tags:''
    });

    a({
        id:683,
        title:"TInputWebDocument",
        content:"TInputWebDocument",
        description:'',
        tags:''
    });

    a({
        id:684,
        title:"TChannelForbidden",
        content:"TChannelForbidden",
        description:'',
        tags:''
    });

    a({
        id:685,
        title:"TPeerChannel",
        content:"TPeerChannel",
        description:'',
        tags:''
    });

    a({
        id:686,
        title:"IInputGeoPoint",
        content:"IInputGeoPoint",
        description:'',
        tags:''
    });

    a({
        id:687,
        title:"TBadMsgNotification",
        content:"TBadMsgNotification",
        description:'',
        tags:''
    });

    a({
        id:688,
        title:"TStickerSetInstallResultSuccess",
        content:"TStickerSetInstallResultSuccess",
        description:'',
        tags:''
    });

    a({
        id:689,
        title:"IFileLocation",
        content:"IFileLocation",
        description:'',
        tags:''
    });

    a({
        id:690,
        title:"TMessageEntityUrl",
        content:"TMessageEntityUrl",
        description:'',
        tags:''
    });

    a({
        id:691,
        title:"TUpdateChatParticipantAdd",
        content:"TUpdateChatParticipantAdd",
        description:'',
        tags:''
    });

    a({
        id:692,
        title:"TLink",
        content:"TLink",
        description:'',
        tags:''
    });

    a({
        id:693,
        title:"TChannelAdminLogEventActionDeleteMessage",
        content:"TChannelAdminLogEventActionDeleteMessage",
        description:'',
        tags:''
    });

    a({
        id:694,
        title:"RequestSaveBigFilePart",
        content:"RequestSaveBigFilePart",
        description:'',
        tags:''
    });

    a({
        id:695,
        title:"RequestClearSavedInfo",
        content:"RequestClearSavedInfo",
        description:'',
        tags:''
    });

    a({
        id:696,
        title:"TChannelParticipantsBots",
        content:"TChannelParticipantsBots",
        description:'',
        tags:''
    });

    a({
        id:697,
        title:"RequestGetDocumentByHash",
        content:"RequestGetDocumentByHash",
        description:'',
        tags:''
    });

    a({
        id:698,
        title:"TInputMessagesFilterChatPhotos",
        content:"TInputMessagesFilterChatPhotos",
        description:'',
        tags:''
    });

    a({
        id:699,
        title:"TWebAuthorizations",
        content:"TWebAuthorizations",
        description:'',
        tags:''
    });

    a({
        id:700,
        title:"TCdnFileReuploadNeeded",
        content:"TCdnFileReuploadNeeded",
        description:'',
        tags:''
    });

    a({
        id:701,
        title:"TPhoneCallProtocol",
        content:"TPhoneCallProtocol",
        description:'',
        tags:''
    });

    a({
        id:702,
        title:"TLangPackStringDeleted",
        content:"TLangPackStringDeleted",
        description:'',
        tags:''
    });

    a({
        id:703,
        title:"IInputPhoto",
        content:"IInputPhoto",
        description:'',
        tags:''
    });

    a({
        id:704,
        title:"TChannelAdminLogEventActionParticipantInvite",
        content:"TChannelAdminLogEventActionParticipantInvite",
        description:'',
        tags:''
    });

    a({
        id:705,
        title:"TChannelAdminRights",
        content:"TChannelAdminRights",
        description:'',
        tags:''
    });

    a({
        id:706,
        title:"RequestCheckUsername",
        content:"RequestCheckUsername",
        description:'',
        tags:''
    });

    a({
        id:707,
        title:"TStickers",
        content:"TStickers",
        description:'',
        tags:''
    });

    a({
        id:708,
        title:"TInputPeerNotifyEventsAll",
        content:"TInputPeerNotifyEventsAll",
        description:'',
        tags:''
    });

    a({
        id:709,
        title:"TDifferenceSlice",
        content:"TDifferenceSlice",
        description:'',
        tags:''
    });

    a({
        id:710,
        title:"TInputUserSelf",
        content:"TInputUserSelf",
        description:'',
        tags:''
    });

    a({
        id:711,
        title:"ITermsOfService",
        content:"ITermsOfService",
        description:'',
        tags:''
    });

    a({
        id:712,
        title:"TInputReportReasonPornography",
        content:"TInputReportReasonPornography",
        description:'',
        tags:''
    });

    a({
        id:713,
        title:"TInputPeerChannel",
        content:"TInputPeerChannel",
        description:'',
        tags:''
    });

    a({
        id:714,
        title:"TEncryptedMessage",
        content:"TEncryptedMessage",
        description:'',
        tags:''
    });

    a({
        id:715,
        title:"TError",
        content:"TError",
        description:'',
        tags:''
    });

    a({
        id:716,
        title:"TSentEncryptedMessage",
        content:"TSentEncryptedMessage",
        description:'',
        tags:''
    });

    a({
        id:717,
        title:"RequestGetLangPack",
        content:"RequestGetLangPack",
        description:'',
        tags:''
    });

    a({
        id:718,
        title:"TInputPhoneCall",
        content:"TInputPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:719,
        title:"RequestGetStickers",
        content:"RequestGetStickers",
        description:'',
        tags:''
    });

    a({
        id:720,
        title:"IInputFileLocation",
        content:"IInputFileLocation",
        description:'',
        tags:''
    });

    a({
        id:721,
        title:"IAffectedHistory",
        content:"IAffectedHistory",
        description:'',
        tags:''
    });

    a({
        id:722,
        title:"TInputStickeredMediaDocument",
        content:"TInputStickeredMediaDocument",
        description:'',
        tags:''
    });

    a({
        id:723,
        title:"TInputNotifyAll",
        content:"TInputNotifyAll",
        description:'',
        tags:''
    });

    a({
        id:724,
        title:"TChatEmpty",
        content:"TChatEmpty",
        description:'',
        tags:''
    });

    a({
        id:725,
        title:"IPasswordRecovery",
        content:"IPasswordRecovery",
        description:'',
        tags:''
    });

    a({
        id:726,
        title:"IChannelMessagesFilter",
        content:"IChannelMessagesFilter",
        description:'',
        tags:''
    });

    a({
        id:727,
        title:"RequestGetRecentMeUrls",
        content:"RequestGetRecentMeUrls",
        description:'',
        tags:''
    });

    a({
        id:728,
        title:"TStickersNotModified",
        content:"TStickersNotModified",
        description:'',
        tags:''
    });

    a({
        id:729,
        title:"RequestResetAuthorization",
        content:"RequestResetAuthorization",
        description:'',
        tags:''
    });

    a({
        id:730,
        title:"RequestResolveUsername",
        content:"RequestResolveUsername",
        description:'',
        tags:''
    });

    a({
        id:731,
        title:"RequestSearchStickerSets",
        content:"RequestSearchStickerSets",
        description:'',
        tags:''
    });

    a({
        id:732,
        title:"TInputPhoto",
        content:"TInputPhoto",
        description:'',
        tags:''
    });

    a({
        id:733,
        title:"TUpdateBotWebhookJSON",
        content:"TUpdateBotWebhookJSON",
        description:'',
        tags:''
    });

    a({
        id:734,
        title:"TChannelDifferenceTooLong",
        content:"TChannelDifferenceTooLong",
        description:'',
        tags:''
    });

    a({
        id:735,
        title:"RequestGetUserPhotos",
        content:"RequestGetUserPhotos",
        description:'',
        tags:''
    });

    a({
        id:736,
        title:"TValidatedRequestedInfo",
        content:"TValidatedRequestedInfo",
        description:'',
        tags:''
    });

    a({
        id:737,
        title:"TDhConfigNotModified",
        content:"TDhConfigNotModified",
        description:'',
        tags:''
    });

    a({
        id:738,
        title:"TUpdateUserPhoto",
        content:"TUpdateUserPhoto",
        description:'',
        tags:''
    });

    a({
        id:739,
        title:"TInputMessagesFilterPhoneCalls",
        content:"TInputMessagesFilterPhoneCalls",
        description:'',
        tags:''
    });

    a({
        id:740,
        title:"TMessageMediaGeo",
        content:"TMessageMediaGeo",
        description:'',
        tags:''
    });

    a({
        id:741,
        title:"TSendMessageRecordVideoAction",
        content:"TSendMessageRecordVideoAction",
        description:'',
        tags:''
    });

    a({
        id:742,
        title:"TState",
        content:"TState",
        description:'',
        tags:''
    });

    a({
        id:743,
        title:"IBotInfo",
        content:"IBotInfo",
        description:'',
        tags:''
    });

    a({
        id:744,
        title:"IDocument",
        content:"IDocument",
        description:'',
        tags:''
    });

    a({
        id:745,
        title:"TPeerUser",
        content:"TPeerUser",
        description:'',
        tags:''
    });

    a({
        id:746,
        title:"TDestroySessionOk",
        content:"TDestroySessionOk",
        description:'',
        tags:''
    });

    a({
        id:747,
        title:"TMessageMediaWebPage",
        content:"TMessageMediaWebPage",
        description:'',
        tags:''
    });

    a({
        id:748,
        title:"TUpdateUserBlocked",
        content:"TUpdateUserBlocked",
        description:'',
        tags:''
    });

    a({
        id:749,
        title:"RequestReorderStickerSets",
        content:"RequestReorderStickerSets",
        description:'',
        tags:''
    });

    a({
        id:750,
        title:"TKeyboardButtonRequestPhone",
        content:"TKeyboardButtonRequestPhone",
        description:'',
        tags:''
    });

    a({
        id:751,
        title:"Utils",
        content:"Utils",
        description:'',
        tags:''
    });

    a({
        id:752,
        title:"IGame",
        content:"IGame",
        description:'',
        tags:''
    });

    a({
        id:753,
        title:"RequestGetInlineGameHighScores",
        content:"RequestGetInlineGameHighScores",
        description:'',
        tags:''
    });

    a({
        id:754,
        title:"TUpdateStickerSetsOrder",
        content:"TUpdateStickerSetsOrder",
        description:'',
        tags:''
    });

    a({
        id:755,
        title:"IHighScore",
        content:"IHighScore",
        description:'',
        tags:''
    });

    a({
        id:756,
        title:"TPageBlockHeader",
        content:"TPageBlockHeader",
        description:'',
        tags:''
    });

    a({
        id:757,
        title:"TExportedAuthorization",
        content:"TExportedAuthorization",
        description:'',
        tags:''
    });

    a({
        id:758,
        title:"IFoundStickerSets",
        content:"IFoundStickerSets",
        description:'',
        tags:''
    });

    a({
        id:759,
        title:"TPageBlockTitle",
        content:"TPageBlockTitle",
        description:'',
        tags:''
    });

    a({
        id:760,
        title:"ILangPackDifference",
        content:"ILangPackDifference",
        description:'',
        tags:''
    });

    a({
        id:761,
        title:"RequestGetBlocked",
        content:"RequestGetBlocked",
        description:'',
        tags:''
    });

    a({
        id:762,
        title:"IResolvedPeer",
        content:"IResolvedPeer",
        description:'',
        tags:''
    });

    a({
        id:763,
        title:"TMessageActionGameScore",
        content:"TMessageActionGameScore",
        description:'',
        tags:''
    });

    a({
        id:764,
        title:"RequestGetWebPagePreview",
        content:"RequestGetWebPagePreview",
        description:'',
        tags:''
    });

    a({
        id:765,
        title:"TNoAppUpdate",
        content:"TNoAppUpdate",
        description:'',
        tags:''
    });

    a({
        id:766,
        title:"TFileHash",
        content:"TFileHash",
        description:'',
        tags:''
    });

    a({
        id:767,
        title:"TUpdateNewMessage",
        content:"TUpdateNewMessage",
        description:'',
        tags:''
    });

    a({
        id:768,
        title:"TContactsNotModified",
        content:"TContactsNotModified",
        description:'',
        tags:''
    });

    a({
        id:769,
        title:"IDataJSON",
        content:"IDataJSON",
        description:'',
        tags:''
    });

    a({
        id:770,
        title:"RequestRegisterDevice",
        content:"RequestRegisterDevice",
        description:'',
        tags:''
    });

    a({
        id:771,
        title:"IInputChannel",
        content:"IInputChannel",
        description:'',
        tags:''
    });

    a({
        id:772,
        title:"IPhoneCallDiscardReason",
        content:"IPhoneCallDiscardReason",
        description:'',
        tags:''
    });

    a({
        id:773,
        title:"TMessageActionChatEditPhoto",
        content:"TMessageActionChatEditPhoto",
        description:'',
        tags:''
    });

    a({
        id:774,
        title:"TSentCodeTypeFlashCall",
        content:"TSentCodeTypeFlashCall",
        description:'',
        tags:''
    });

    a({
        id:775,
        title:"TUpdatesTooLong",
        content:"TUpdatesTooLong",
        description:'',
        tags:''
    });

    a({
        id:776,
        title:"RequestDeleteChatUser",
        content:"RequestDeleteChatUser",
        description:'',
        tags:''
    });

    a({
        id:777,
        title:"TPaymentResult",
        content:"TPaymentResult",
        description:'',
        tags:''
    });

    a({
        id:778,
        title:"TAccountDaysTTL",
        content:"TAccountDaysTTL",
        description:'',
        tags:''
    });

    a({
        id:779,
        title:"TPeerSettings",
        content:"TPeerSettings",
        description:'',
        tags:''
    });

    a({
        id:780,
        title:"TChatInvite",
        content:"TChatInvite",
        description:'',
        tags:''
    });

    a({
        id:781,
        title:"INotifyPeer",
        content:"INotifyPeer",
        description:'',
        tags:''
    });

    a({
        id:782,
        title:"RequestEditBanned",
        content:"RequestEditBanned",
        description:'',
        tags:''
    });

    a({
        id:783,
        title:"IContactLink",
        content:"IContactLink",
        description:'',
        tags:''
    });

    a({
        id:784,
        title:"IPeerNotifySettings",
        content:"IPeerNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:785,
        title:"TUserProfilePhotoEmpty",
        content:"TUserProfilePhotoEmpty",
        description:'',
        tags:''
    });

    a({
        id:786,
        title:"RequestSetBotCallbackAnswer",
        content:"RequestSetBotCallbackAnswer",
        description:'',
        tags:''
    });

    a({
        id:787,
        title:"TBotInlineMessageMediaContact",
        content:"TBotInlineMessageMediaContact",
        description:'',
        tags:''
    });

    a({
        id:788,
        title:"TRecentStickersNotModified",
        content:"TRecentStickersNotModified",
        description:'',
        tags:''
    });

    a({
        id:789,
        title:"TPhoto",
        content:"TPhoto",
        description:'',
        tags:''
    });

    a({
        id:790,
        title:"IChannelParticipant",
        content:"IChannelParticipant",
        description:'',
        tags:''
    });

    a({
        id:791,
        title:"IContactBlocked",
        content:"IContactBlocked",
        description:'',
        tags:''
    });

    a({
        id:792,
        title:"IStickerSet",
        content:"IStickerSet",
        description:'',
        tags:''
    });

    a({
        id:793,
        title:"RequestUploadProfilePhoto",
        content:"RequestUploadProfilePhoto",
        description:'',
        tags:''
    });

    a({
        id:794,
        title:"TPageBlockList",
        content:"TPageBlockList",
        description:'',
        tags:''
    });

    a({
        id:795,
        title:"TChannelMessagesFilterEmpty",
        content:"TChannelMessagesFilterEmpty",
        description:'',
        tags:''
    });

    a({
        id:796,
        title:"TReplyKeyboardHide",
        content:"TReplyKeyboardHide",
        description:'',
        tags:''
    });

    a({
        id:797,
        title:"TResPQ",
        content:"TResPQ",
        description:'',
        tags:''
    });

    a({
        id:798,
        title:"IPasswordInputSettings",
        content:"IPasswordInputSettings",
        description:'',
        tags:''
    });

    a({
        id:799,
        title:"TRpcAnswerDropped",
        content:"TRpcAnswerDropped",
        description:'',
        tags:''
    });

    a({
        id:800,
        title:"TTextEmail",
        content:"TTextEmail",
        description:'',
        tags:''
    });

    a({
        id:801,
        title:"TTopPeerCategoryBotsInline",
        content:"TTopPeerCategoryBotsInline",
        description:'',
        tags:''
    });

    a({
        id:802,
        title:"IContacts",
        content:"IContacts",
        description:'',
        tags:''
    });

    a({
        id:803,
        title:"TUpdateChannelAvailableMessages",
        content:"TUpdateChannelAvailableMessages",
        description:'',
        tags:''
    });

    a({
        id:804,
        title:"TPrivacyKeyPhoneCall",
        content:"TPrivacyKeyPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:805,
        title:"TPhotos",
        content:"TPhotos",
        description:'',
        tags:''
    });

    a({
        id:806,
        title:"RequestPing",
        content:"RequestPing",
        description:'',
        tags:''
    });

    a({
        id:807,
        title:"IInputChatPhotoCommon",
        content:"IInputChatPhotoCommon",
        description:'',
        tags:''
    });

    a({
        id:808,
        title:"TPageBlockFooter",
        content:"TPageBlockFooter",
        description:'',
        tags:''
    });

    a({
        id:809,
        title:"IInputUserCommon",
        content:"IInputUserCommon",
        description:'',
        tags:''
    });

    a({
        id:810,
        title:"TCdnFile",
        content:"TCdnFile",
        description:'',
        tags:''
    });

    a({
        id:811,
        title:"RequestRequestCall",
        content:"RequestRequestCall",
        description:'',
        tags:''
    });

    a({
        id:812,
        title:"TPhotosSlice",
        content:"TPhotosSlice",
        description:'',
        tags:''
    });

    a({
        id:813,
        title:"IInputStickerSet",
        content:"IInputStickerSet",
        description:'',
        tags:''
    });

    a({
        id:814,
        title:"TUpdateWebPage",
        content:"TUpdateWebPage",
        description:'',
        tags:''
    });

    a({
        id:815,
        title:"IAuthorization",
        content:"IAuthorization",
        description:'',
        tags:''
    });

    a({
        id:816,
        title:"TMsgsAllInfo",
        content:"TMsgsAllInfo",
        description:'',
        tags:''
    });

    a({
        id:817,
        title:"TPhoto",
        content:"TPhoto",
        description:'',
        tags:''
    });

    a({
        id:818,
        title:"RequestUploadEncryptedFile",
        content:"RequestUploadEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:819,
        title:"TMessageEntityBold",
        content:"TMessageEntityBold",
        description:'',
        tags:''
    });

    a({
        id:820,
        title:"TMessageEntityUnknown",
        content:"TMessageEntityUnknown",
        description:'',
        tags:''
    });

    a({
        id:821,
        title:"TUpdateUserPhone",
        content:"TUpdateUserPhone",
        description:'',
        tags:''
    });

    a({
        id:822,
        title:"RequestDeleteHistory",
        content:"RequestDeleteHistory",
        description:'',
        tags:''
    });

    a({
        id:823,
        title:"IMessagesFilterCommon",
        content:"IMessagesFilterCommon",
        description:'',
        tags:''
    });

    a({
        id:824,
        title:"TPopularContact",
        content:"TPopularContact",
        description:'',
        tags:''
    });

    a({
        id:825,
        title:"ITopPeerCategory",
        content:"ITopPeerCategory",
        description:'',
        tags:''
    });

    a({
        id:826,
        title:"TPageBlockVideo",
        content:"TPageBlockVideo",
        description:'',
        tags:''
    });

    a({
        id:827,
        title:"TMessageMediaDocument",
        content:"TMessageMediaDocument",
        description:'',
        tags:''
    });

    a({
        id:828,
        title:"TFilePdf",
        content:"TFilePdf",
        description:'',
        tags:''
    });

    a({
        id:829,
        title:"ICdnConfig",
        content:"ICdnConfig",
        description:'',
        tags:''
    });

    a({
        id:830,
        title:"TTextUnderline",
        content:"TTextUnderline",
        description:'',
        tags:''
    });

    a({
        id:831,
        title:"TPhoneCall",
        content:"TPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:832,
        title:"TWebAuthorization",
        content:"TWebAuthorization",
        description:'',
        tags:''
    });

    a({
        id:833,
        title:"RequestReadFeaturedStickers",
        content:"RequestReadFeaturedStickers",
        description:'',
        tags:''
    });

    a({
        id:834,
        title:"TFileCdnRedirect",
        content:"TFileCdnRedirect",
        description:'',
        tags:''
    });

    a({
        id:835,
        title:"TImportedContacts",
        content:"TImportedContacts",
        description:'',
        tags:''
    });

    a({
        id:836,
        title:"INearestDc",
        content:"INearestDc",
        description:'',
        tags:''
    });

    a({
        id:837,
        title:"TRecentStickers",
        content:"TRecentStickers",
        description:'',
        tags:''
    });

    a({
        id:838,
        title:"IPaymentForm",
        content:"IPaymentForm",
        description:'',
        tags:''
    });

    a({
        id:839,
        title:"IObject",
        content:"IObject",
        description:'',
        tags:''
    });

    a({
        id:840,
        title:"TInputChannel",
        content:"TInputChannel",
        description:'',
        tags:''
    });

    a({
        id:841,
        title:"TInputStickerSetItem",
        content:"TInputStickerSetItem",
        description:'',
        tags:''
    });

    a({
        id:842,
        title:"RequestUnblock",
        content:"RequestUnblock",
        description:'',
        tags:''
    });

    a({
        id:843,
        title:"IBotResults",
        content:"IBotResults",
        description:'',
        tags:''
    });

    a({
        id:844,
        title:"TClientDHInnerData",
        content:"TClientDHInnerData",
        description:'',
        tags:''
    });

    a({
        id:845,
        title:"TInputPrivacyKeyStatusTimestamp",
        content:"TInputPrivacyKeyStatusTimestamp",
        description:'',
        tags:''
    });

    a({
        id:846,
        title:"TRpcError",
        content:"TRpcError",
        description:'',
        tags:''
    });

    a({
        id:847,
        title:"TLangPackString",
        content:"TLangPackString",
        description:'',
        tags:''
    });

    a({
        id:848,
        title:"TUpdatePrivacy",
        content:"TUpdatePrivacy",
        description:'',
        tags:''
    });

    a({
        id:849,
        title:"TPhoneCallDiscardReasonDisconnect",
        content:"TPhoneCallDiscardReasonDisconnect",
        description:'',
        tags:''
    });

    a({
        id:850,
        title:"RequestGetCdnConfig",
        content:"RequestGetCdnConfig",
        description:'',
        tags:''
    });

    a({
        id:851,
        title:"TInputEncryptedFile",
        content:"TInputEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:852,
        title:"IEmpty",
        content:"IEmpty",
        description:'',
        tags:''
    });

    a({
        id:853,
        title:"TChannelAdminLogEventActionChangeUsername",
        content:"TChannelAdminLogEventActionChangeUsername",
        description:'',
        tags:''
    });

    a({
        id:854,
        title:"TUpdateConfig",
        content:"TUpdateConfig",
        description:'',
        tags:''
    });

    a({
        id:855,
        title:"RequestDeleteChannel",
        content:"RequestDeleteChannel",
        description:'',
        tags:''
    });

    a({
        id:856,
        title:"TPaymentSavedCredentialsCard",
        content:"TPaymentSavedCredentialsCard",
        description:'',
        tags:''
    });

    a({
        id:857,
        title:"TInputMessageReplyTo",
        content:"TInputMessageReplyTo",
        description:'',
        tags:''
    });

    a({
        id:858,
        title:"TChannelAdminLogEventActionTogglePreHistoryHidden",
        content:"TChannelAdminLogEventActionTogglePreHistoryHidden",
        description:'',
        tags:''
    });

    a({
        id:859,
        title:"TDialogs",
        content:"TDialogs",
        description:'',
        tags:''
    });

    a({
        id:860,
        title:"IDhConfig",
        content:"IDhConfig",
        description:'',
        tags:''
    });

    a({
        id:861,
        title:"THttpWait",
        content:"THttpWait",
        description:'',
        tags:''
    });

    a({
        id:862,
        title:"IShippingOption",
        content:"IShippingOption",
        description:'',
        tags:''
    });

    a({
        id:863,
        title:"TDocumentAttributeAnimated",
        content:"TDocumentAttributeAnimated",
        description:'',
        tags:''
    });

    a({
        id:864,
        title:"TChannelAdminLogEventActionToggleSignatures",
        content:"TChannelAdminLogEventActionToggleSignatures",
        description:'',
        tags:''
    });

    a({
        id:865,
        title:"IChannelAdminRights",
        content:"IChannelAdminRights",
        description:'',
        tags:''
    });

    a({
        id:866,
        title:"TFoundGifs",
        content:"TFoundGifs",
        description:'',
        tags:''
    });

    a({
        id:867,
        title:"TUpdateNewChannelMessage",
        content:"TUpdateNewChannelMessage",
        description:'',
        tags:''
    });

    a({
        id:868,
        title:"TPhoneConnection",
        content:"TPhoneConnection",
        description:'',
        tags:''
    });

    a({
        id:869,
        title:"TMessageActionChatEditTitle",
        content:"TMessageActionChatEditTitle",
        description:'',
        tags:''
    });

    a({
        id:870,
        title:"TInputGeoPointEmpty",
        content:"TInputGeoPointEmpty",
        description:'',
        tags:''
    });

    a({
        id:871,
        title:"TTopPeerCategoryPeers",
        content:"TTopPeerCategoryPeers",
        description:'',
        tags:''
    });

    a({
        id:872,
        title:"TTopPeerCategoryCorrespondents",
        content:"TTopPeerCategoryCorrespondents",
        description:'',
        tags:''
    });

    a({
        id:873,
        title:"TRecentMeUrls",
        content:"TRecentMeUrls",
        description:'',
        tags:''
    });

    a({
        id:874,
        title:"TMessageActionEmpty",
        content:"TMessageActionEmpty",
        description:'',
        tags:''
    });

    a({
        id:875,
        title:"TContactLinkUnknown",
        content:"TContactLinkUnknown",
        description:'',
        tags:''
    });

    a({
        id:876,
        title:"TInputEncryptedFileUploaded",
        content:"TInputEncryptedFileUploaded",
        description:'',
        tags:''
    });

    a({
        id:877,
        title:"TWebPagePending",
        content:"TWebPagePending",
        description:'',
        tags:''
    });

    a({
        id:878,
        title:"IWebPage",
        content:"IWebPage",
        description:'',
        tags:''
    });

    a({
        id:879,
        title:"IRecentStickers",
        content:"IRecentStickers",
        description:'',
        tags:''
    });

    a({
        id:880,
        title:"TUpdateDeleteChannelMessages",
        content:"TUpdateDeleteChannelMessages",
        description:'',
        tags:''
    });

    a({
        id:881,
        title:"RequestGetAllChats",
        content:"RequestGetAllChats",
        description:'',
        tags:''
    });

    a({
        id:882,
        title:"TStickerSetInstallResultArchive",
        content:"TStickerSetInstallResultArchive",
        description:'',
        tags:''
    });

    a({
        id:883,
        title:"TRecentMeUrlUser",
        content:"TRecentMeUrlUser",
        description:'',
        tags:''
    });

    a({
        id:884,
        title:"RequestDeleteHistory",
        content:"RequestDeleteHistory",
        description:'',
        tags:''
    });

    a({
        id:885,
        title:"RequestGetFeaturedStickers",
        content:"RequestGetFeaturedStickers",
        description:'',
        tags:''
    });

    a({
        id:886,
        title:"IChannelParticipant",
        content:"IChannelParticipant",
        description:'',
        tags:''
    });

    a({
        id:887,
        title:"TUpdateBotCallbackQuery",
        content:"TUpdateBotCallbackQuery",
        description:'',
        tags:''
    });

    a({
        id:888,
        title:"IDcOption",
        content:"IDcOption",
        description:'',
        tags:''
    });

    a({
        id:889,
        title:"TCodeTypeSms",
        content:"TCodeTypeSms",
        description:'',
        tags:''
    });

    a({
        id:890,
        title:"IAdminLogResults",
        content:"IAdminLogResults",
        description:'',
        tags:''
    });

    a({
        id:891,
        title:"TContactStatus",
        content:"TContactStatus",
        description:'',
        tags:''
    });

    a({
        id:892,
        title:"TEncryptedChatWaiting",
        content:"TEncryptedChatWaiting",
        description:'',
        tags:''
    });

    a({
        id:893,
        title:"RequestSendMedia",
        content:"RequestSendMedia",
        description:'',
        tags:''
    });

    a({
        id:894,
        title:"RequestUpdateUsername",
        content:"RequestUpdateUsername",
        description:'',
        tags:''
    });

    a({
        id:895,
        title:"TUpdateShortSentMessage",
        content:"TUpdateShortSentMessage",
        description:'',
        tags:''
    });

    a({
        id:896,
        title:"TMessages",
        content:"TMessages",
        description:'',
        tags:''
    });

    a({
        id:897,
        title:"TUpdateServiceNotification",
        content:"TUpdateServiceNotification",
        description:'',
        tags:''
    });

    a({
        id:898,
        title:"TWebPage",
        content:"TWebPage",
        description:'',
        tags:''
    });

    a({
        id:899,
        title:"TMessageMediaVenue",
        content:"TMessageMediaVenue",
        description:'',
        tags:''
    });

    a({
        id:900,
        title:"IImportedContacts",
        content:"IImportedContacts",
        description:'',
        tags:''
    });

    a({
        id:901,
        title:"RequestGetLanguages",
        content:"RequestGetLanguages",
        description:'',
        tags:''
    });

    a({
        id:902,
        title:"TUpdateShortMessage",
        content:"TUpdateShortMessage",
        description:'',
        tags:''
    });

    a({
        id:903,
        title:"IPhoto",
        content:"IPhoto",
        description:'',
        tags:''
    });

    a({
        id:904,
        title:"TEncryptedChat",
        content:"TEncryptedChat",
        description:'',
        tags:''
    });

    a({
        id:905,
        title:"TMessageEditData",
        content:"TMessageEditData",
        description:'',
        tags:''
    });

    a({
        id:906,
        title:"RequestGetConfig",
        content:"RequestGetConfig",
        description:'',
        tags:''
    });

    a({
        id:907,
        title:"TUpdateReadFeaturedStickers",
        content:"TUpdateReadFeaturedStickers",
        description:'',
        tags:''
    });

    a({
        id:908,
        title:"TInputWebFileLocation",
        content:"TInputWebFileLocation",
        description:'',
        tags:''
    });

    a({
        id:909,
        title:"TFutureSalt",
        content:"TFutureSalt",
        description:'',
        tags:''
    });

    a({
        id:910,
        title:"TUpdatePhoneCall",
        content:"TUpdatePhoneCall",
        description:'',
        tags:''
    });

    a({
        id:911,
        title:"TFileUnknown",
        content:"TFileUnknown",
        description:'',
        tags:''
    });

    a({
        id:912,
        title:"RequestGetStrings",
        content:"RequestGetStrings",
        description:'',
        tags:''
    });

    a({
        id:913,
        title:"IMessageFwdHeader",
        content:"IMessageFwdHeader",
        description:'',
        tags:''
    });

    a({
        id:914,
        title:"IPeerNotifyEvents",
        content:"IPeerNotifyEvents",
        description:'',
        tags:''
    });

    a({
        id:915,
        title:"IInputBotInlineMessage",
        content:"IInputBotInlineMessage",
        description:'',
        tags:''
    });

    a({
        id:916,
        title:"TReplyInlineMarkup",
        content:"TReplyInlineMarkup",
        description:'',
        tags:''
    });

    a({
        id:917,
        title:"RequestGetAdminedPublicChannels",
        content:"RequestGetAdminedPublicChannels",
        description:'',
        tags:''
    });

    a({
        id:918,
        title:"TUpdateChatParticipantDelete",
        content:"TUpdateChatParticipantDelete",
        description:'',
        tags:''
    });

    a({
        id:919,
        title:"TContactBlocked",
        content:"TContactBlocked",
        description:'',
        tags:''
    });

    a({
        id:920,
        title:"TUpdateChatAdmins",
        content:"TUpdateChatAdmins",
        description:'',
        tags:''
    });

    a({
        id:921,
        title:"RequestGetChats",
        content:"RequestGetChats",
        description:'',
        tags:''
    });

    a({
        id:922,
        title:"TChatParticipantCreator",
        content:"TChatParticipantCreator",
        description:'',
        tags:''
    });

    a({
        id:923,
        title:"TInputPrivacyValueDisallowUsers",
        content:"TInputPrivacyValueDisallowUsers",
        description:'',
        tags:''
    });

    a({
        id:924,
        title:"RequestSignIn",
        content:"RequestSignIn",
        description:'',
        tags:''
    });

    a({
        id:925,
        title:"TSendMessageUploadDocumentAction",
        content:"TSendMessageUploadDocumentAction",
        description:'',
        tags:''
    });

    a({
        id:926,
        title:"RequestReuploadCdnFile",
        content:"RequestReuploadCdnFile",
        description:'',
        tags:''
    });

    a({
        id:927,
        title:"TUpdateContactRegistered",
        content:"TUpdateContactRegistered",
        description:'',
        tags:''
    });

    a({
        id:928,
        title:"TSavedGifs",
        content:"TSavedGifs",
        description:'',
        tags:''
    });

    a({
        id:929,
        title:"RequestReorderPinnedDialogs",
        content:"RequestReorderPinnedDialogs",
        description:'',
        tags:''
    });

    a({
        id:930,
        title:"TCodeTypeFlashCall",
        content:"TCodeTypeFlashCall",
        description:'',
        tags:''
    });

    a({
        id:931,
        title:"TDocumentEmpty",
        content:"TDocumentEmpty",
        description:'',
        tags:''
    });

    a({
        id:932,
        title:"TUpdateReadHistoryOutbox",
        content:"TUpdateReadHistoryOutbox",
        description:'',
        tags:''
    });

    a({
        id:933,
        title:"TInputMessageID",
        content:"TInputMessageID",
        description:'',
        tags:''
    });

    a({
        id:934,
        title:"TChannelParticipantsBanned",
        content:"TChannelParticipantsBanned",
        description:'',
        tags:''
    });

    a({
        id:935,
        title:"TDhGenOk",
        content:"TDhGenOk",
        description:'',
        tags:''
    });

    a({
        id:936,
        title:"TNotifyChats",
        content:"TNotifyChats",
        description:'',
        tags:''
    });

    a({
        id:937,
        title:"TChatPhoto",
        content:"TChatPhoto",
        description:'',
        tags:''
    });

    a({
        id:938,
        title:"RequestHideReportSpam",
        content:"RequestHideReportSpam",
        description:'',
        tags:''
    });

    a({
        id:939,
        title:"TUpdateNotifySettings",
        content:"TUpdateNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:940,
        title:"TMessageMediaContact",
        content:"TMessageMediaContact",
        description:'',
        tags:''
    });

    a({
        id:941,
        title:"IUser",
        content:"IUser",
        description:'',
        tags:''
    });

    a({
        id:942,
        title:"TInputStickerSetEmpty",
        content:"TInputStickerSetEmpty",
        description:'',
        tags:''
    });

    a({
        id:943,
        title:"RequestGetFutureSalts",
        content:"RequestGetFutureSalts",
        description:'',
        tags:''
    });

    a({
        id:944,
        title:"TUpdateChannelPinnedMessage",
        content:"TUpdateChannelPinnedMessage",
        description:'',
        tags:''
    });

    a({
        id:945,
        title:"TSendMessageRecordAudioAction",
        content:"TSendMessageRecordAudioAction",
        description:'',
        tags:''
    });

    a({
        id:946,
        title:"TInputPhotoEmpty",
        content:"TInputPhotoEmpty",
        description:'',
        tags:''
    });

    a({
        id:947,
        title:"TPhoneCallDiscardReasonMissed",
        content:"TPhoneCallDiscardReasonMissed",
        description:'',
        tags:''
    });

    a({
        id:948,
        title:"RequestPingDelayDisconnect",
        content:"RequestPingDelayDisconnect",
        description:'',
        tags:''
    });

    a({
        id:949,
        title:"TEncryptedChatEmpty",
        content:"TEncryptedChatEmpty",
        description:'',
        tags:''
    });

    a({
        id:950,
        title:"TMessagesSlice",
        content:"TMessagesSlice",
        description:'',
        tags:''
    });

    a({
        id:951,
        title:"RequestGetWebFile",
        content:"RequestGetWebFile",
        description:'',
        tags:''
    });

    a({
        id:952,
        title:"RequestGetMessageEditData",
        content:"RequestGetMessageEditData",
        description:'',
        tags:''
    });

    a({
        id:953,
        title:"SchemaInfo",
        content:"SchemaInfo",
        description:'',
        tags:''
    });

    a({
        id:954,
        title:"IRequest",
        content:"IRequest",
        description:'',
        tags:''
    });

    a({
        id:955,
        title:"TUpdateChatUserTyping",
        content:"TUpdateChatUserTyping",
        description:'',
        tags:''
    });

    a({
        id:956,
        title:"RequestSendEncryptedFile",
        content:"RequestSendEncryptedFile",
        description:'',
        tags:''
    });

    a({
        id:957,
        title:"RequestGetMaskStickers",
        content:"RequestGetMaskStickers",
        description:'',
        tags:''
    });

    a({
        id:958,
        title:"IInputStickerSetCommon",
        content:"IInputStickerSetCommon",
        description:'',
        tags:''
    });

    a({
        id:959,
        title:"TDestroyAuthKeyNone",
        content:"TDestroyAuthKeyNone",
        description:'',
        tags:''
    });

    a({
        id:960,
        title:"TInputBotInlineMessageMediaContact",
        content:"TInputBotInlineMessageMediaContact",
        description:'',
        tags:''
    });

    a({
        id:961,
        title:"TInputMediaVenue",
        content:"TInputMediaVenue",
        description:'',
        tags:''
    });

    a({
        id:962,
        title:"TNotifyAll",
        content:"TNotifyAll",
        description:'',
        tags:''
    });

    a({
        id:963,
        title:"TMessageMediaGame",
        content:"TMessageMediaGame",
        description:'',
        tags:''
    });

    a({
        id:964,
        title:"ILangPackString",
        content:"ILangPackString",
        description:'',
        tags:''
    });

    a({
        id:965,
        title:"IInputFile",
        content:"IInputFile",
        description:'',
        tags:''
    });

    a({
        id:966,
        title:"TStickerSet",
        content:"TStickerSet",
        description:'',
        tags:''
    });

    a({
        id:967,
        title:"IPhoneCallCommon",
        content:"IPhoneCallCommon",
        description:'',
        tags:''
    });

    a({
        id:968,
        title:"TMessageFwdHeader",
        content:"TMessageFwdHeader",
        description:'',
        tags:''
    });

    a({
        id:969,
        title:"TInputChatPhoto",
        content:"TInputChatPhoto",
        description:'',
        tags:''
    });

    a({
        id:970,
        title:"IUserFull",
        content:"IUserFull",
        description:'',
        tags:''
    });

    a({
        id:971,
        title:"RequestDestroyAuthKey",
        content:"RequestDestroyAuthKey",
        description:'',
        tags:''
    });

    a({
        id:972,
        title:"IValidatedRequestedInfo",
        content:"IValidatedRequestedInfo",
        description:'',
        tags:''
    });

    a({
        id:973,
        title:"RequestGetStickerSet",
        content:"RequestGetStickerSet",
        description:'',
        tags:''
    });

    a({
        id:974,
        title:"TMessageEntityPre",
        content:"TMessageEntityPre",
        description:'',
        tags:''
    });

    a({
        id:975,
        title:"RequestValidateRequestedInfo",
        content:"RequestValidateRequestedInfo",
        description:'',
        tags:''
    });

    a({
        id:976,
        title:"TPasswordInputSettings",
        content:"TPasswordInputSettings",
        description:'',
        tags:''
    });

    a({
        id:977,
        title:"IInputAppEvent",
        content:"IInputAppEvent",
        description:'',
        tags:''
    });

    a({
        id:978,
        title:"TUserStatusRecently",
        content:"TUserStatusRecently",
        description:'',
        tags:''
    });

    a({
        id:979,
        title:"TContacts",
        content:"TContacts",
        description:'',
        tags:''
    });

    a({
        id:980,
        title:"RequestUploadMedia",
        content:"RequestUploadMedia",
        description:'',
        tags:''
    });

    a({
        id:981,
        title:"TAuthorization",
        content:"TAuthorization",
        description:'',
        tags:''
    });

    a({
        id:982,
        title:"TInputStickerSetID",
        content:"TInputStickerSetID",
        description:'',
        tags:''
    });

    a({
        id:983,
        title:"TUpdateChannelMessageViews",
        content:"TUpdateChannelMessageViews",
        description:'',
        tags:''
    });

    a({
        id:984,
        title:"TMsgsAck",
        content:"TMsgsAck",
        description:'',
        tags:''
    });

    a({
        id:985,
        title:"RequestGetFullChannel",
        content:"RequestGetFullChannel",
        description:'',
        tags:''
    });

    a({
        id:986,
        title:"TAuthorization",
        content:"TAuthorization",
        description:'',
        tags:''
    });

    a({
        id:987,
        title:"TPageBlockUnsupported",
        content:"TPageBlockUnsupported",
        description:'',
        tags:''
    });

    a({
        id:988,
        title:"RequestGetPasswordSettings",
        content:"RequestGetPasswordSettings",
        description:'',
        tags:''
    });

    a({
        id:989,
        title:"IRequest",
        content:"IRequest",
        description:'',
        tags:''
    });

    a({
        id:990,
        title:"TNewSessionCreated",
        content:"TNewSessionCreated",
        description:'',
        tags:''
    });

    a({
        id:991,
        title:"IInputStickerSetItem",
        content:"IInputStickerSetItem",
        description:'',
        tags:''
    });

    a({
        id:992,
        title:"TUpdateLangPackTooLong",
        content:"TUpdateLangPackTooLong",
        description:'',
        tags:''
    });

    a({
        id:993,
        title:"IInputUser",
        content:"IInputUser",
        description:'',
        tags:''
    });

    a({
        id:994,
        title:"TUserStatusOnline",
        content:"TUserStatusOnline",
        description:'',
        tags:''
    });

    a({
        id:995,
        title:"TLangPackDifference",
        content:"TLangPackDifference",
        description:'',
        tags:''
    });

    a({
        id:996,
        title:"IInputMediaCommon",
        content:"IInputMediaCommon",
        description:'',
        tags:''
    });

    a({
        id:997,
        title:"RequestRemoveStickerFromSet",
        content:"RequestRemoveStickerFromSet",
        description:'',
        tags:''
    });

    a({
        id:998,
        title:"RequestInviteToChannel",
        content:"RequestInviteToChannel",
        description:'',
        tags:''
    });

    a({
        id:999,
        title:"TInputMediaGeoLive",
        content:"TInputMediaGeoLive",
        description:'',
        tags:''
    });

    a({
        id:1000,
        title:"IExportedMessageLink",
        content:"IExportedMessageLink",
        description:'',
        tags:''
    });

    a({
        id:1001,
        title:"TSendMessageUploadAudioAction",
        content:"TSendMessageUploadAudioAction",
        description:'',
        tags:''
    });

    a({
        id:1002,
        title:"TNearestDc",
        content:"TNearestDc",
        description:'',
        tags:''
    });

    a({
        id:1003,
        title:"RequestUpdateProfile",
        content:"RequestUpdateProfile",
        description:'',
        tags:''
    });

    a({
        id:1004,
        title:"RequestGetTermsOfService",
        content:"RequestGetTermsOfService",
        description:'',
        tags:''
    });

    a({
        id:1005,
        title:"TPrivacyRules",
        content:"TPrivacyRules",
        description:'',
        tags:''
    });

    a({
        id:1006,
        title:"TInputFile",
        content:"TInputFile",
        description:'',
        tags:''
    });

    a({
        id:1007,
        title:"RequestReportEncryptedSpam",
        content:"RequestReportEncryptedSpam",
        description:'',
        tags:''
    });

    a({
        id:1008,
        title:"TPageBlockAudio",
        content:"TPageBlockAudio",
        description:'',
        tags:''
    });

    a({
        id:1009,
        title:"TChannelParticipantSelf",
        content:"TChannelParticipantSelf",
        description:'',
        tags:''
    });

    a({
        id:1010,
        title:"TEncryptedChatDiscarded",
        content:"TEncryptedChatDiscarded",
        description:'',
        tags:''
    });

    a({
        id:1011,
        title:"TInputChannelEmpty",
        content:"TInputChannelEmpty",
        description:'',
        tags:''
    });

    a({
        id:1012,
        title:"TUpdateContactsReset",
        content:"TUpdateContactsReset",
        description:'',
        tags:''
    });

    a({
        id:1013,
        title:"TInputPrivacyValueDisallowContacts",
        content:"TInputPrivacyValueDisallowContacts",
        description:'',
        tags:''
    });

    a({
        id:1014,
        title:"TInputChatPhotoEmpty",
        content:"TInputChatPhotoEmpty",
        description:'',
        tags:''
    });

    a({
        id:1015,
        title:"RequestCheckUsername",
        content:"RequestCheckUsername",
        description:'',
        tags:''
    });

    a({
        id:1016,
        title:"TPhoneCallWaiting",
        content:"TPhoneCallWaiting",
        description:'',
        tags:''
    });

    a({
        id:1017,
        title:"ICodeType",
        content:"ICodeType",
        description:'',
        tags:''
    });

    a({
        id:1018,
        title:"TAllStickersNotModified",
        content:"TAllStickersNotModified",
        description:'',
        tags:''
    });

    a({
        id:1019,
        title:"RequestExportCard",
        content:"RequestExportCard",
        description:'',
        tags:''
    });

    a({
        id:1020,
        title:"TUpdateDeleteMessages",
        content:"TUpdateDeleteMessages",
        description:'',
        tags:''
    });

    a({
        id:1021,
        title:"TPhotoCachedSize",
        content:"TPhotoCachedSize",
        description:'',
        tags:''
    });

    a({
        id:1022,
        title:"TDhGenFail",
        content:"TDhGenFail",
        description:'',
        tags:''
    });

    a({
        id:1023,
        title:"TUpdateReadHistoryInbox",
        content:"TUpdateReadHistoryInbox",
        description:'',
        tags:''
    });

    a({
        id:1024,
        title:"RequestAnswerWebhookJSONQuery",
        content:"RequestAnswerWebhookJSONQuery",
        description:'',
        tags:''
    });

    a({
        id:1025,
        title:"TReceivedNotifyMessage",
        content:"TReceivedNotifyMessage",
        description:'',
        tags:''
    });

    a({
        id:1026,
        title:"ICdnPublicKey",
        content:"ICdnPublicKey",
        description:'',
        tags:''
    });

    a({
        id:1027,
        title:"IInviteText",
        content:"IInviteText",
        description:'',
        tags:''
    });

    a({
        id:1028,
        title:"IPasswordSettings",
        content:"IPasswordSettings",
        description:'',
        tags:''
    });

    a({
        id:1029,
        title:"RequestUpdatePinnedMessage",
        content:"RequestUpdatePinnedMessage",
        description:'',
        tags:''
    });

    a({
        id:1030,
        title:"ITopPeerCategoryPeers",
        content:"ITopPeerCategoryPeers",
        description:'',
        tags:''
    });

    a({
        id:1031,
        title:"TMessageActionCustomAction",
        content:"TMessageActionCustomAction",
        description:'',
        tags:''
    });

    a({
        id:1032,
        title:"IRichTextCommon",
        content:"IRichTextCommon",
        description:'',
        tags:''
    });

    a({
        id:1033,
        title:"TInputMediaDocument",
        content:"TInputMediaDocument",
        description:'',
        tags:''
    });

    a({
        id:1034,
        title:"TChannel",
        content:"TChannel",
        description:'',
        tags:''
    });

    a({
        id:1035,
        title:"TLangPackLanguage",
        content:"TLangPackLanguage",
        description:'',
        tags:''
    });

    a({
        id:1036,
        title:"TInvoice",
        content:"TInvoice",
        description:'',
        tags:''
    });

    a({
        id:1037,
        title:"TNotifyUsers",
        content:"TNotifyUsers",
        description:'',
        tags:''
    });

    a({
        id:1038,
        title:"TDialogsSlice",
        content:"TDialogsSlice",
        description:'',
        tags:''
    });

    a({
        id:1039,
        title:"RequestSetEncryptedTyping",
        content:"RequestSetEncryptedTyping",
        description:'',
        tags:''
    });

    a({
        id:1040,
        title:"TMessageActionPaymentSentMe",
        content:"TMessageActionPaymentSentMe",
        description:'',
        tags:''
    });

    a({
        id:1041,
        title:"RequestSearch",
        content:"RequestSearch",
        description:'',
        tags:''
    });

    a({
        id:1042,
        title:"TInputStickerSetShortName",
        content:"TInputStickerSetShortName",
        description:'',
        tags:''
    });

    a({
        id:1043,
        title:"TUpdateLangPack",
        content:"TUpdateLangPack",
        description:'',
        tags:''
    });

    a({
        id:1044,
        title:"IHighScores",
        content:"IHighScores",
        description:'',
        tags:''
    });

    a({
        id:1045,
        title:"IFileHash",
        content:"IFileHash",
        description:'',
        tags:''
    });

    a({
        id:1046,
        title:"RequestSendPaymentForm",
        content:"RequestSendPaymentForm",
        description:'',
        tags:''
    });

    a({
        id:1047,
        title:"RequestGetSavedInfo",
        content:"RequestGetSavedInfo",
        description:'',
        tags:''
    });

    a({
        id:1048,
        title:"RequestCreateChannel",
        content:"RequestCreateChannel",
        description:'',
        tags:''
    });

    a({
        id:1049,
        title:"TPageBlockEmbedPost",
        content:"TPageBlockEmbedPost",
        description:'',
        tags:''
    });

    a({
        id:1050,
        title:"TKeyboardButtonUrl",
        content:"TKeyboardButtonUrl",
        description:'',
        tags:''
    });

    a({
        id:1051,
        title:"RequestGetAllStickers",
        content:"RequestGetAllStickers",
        description:'',
        tags:''
    });

    a({
        id:1052,
        title:"IRecentMeUrls",
        content:"IRecentMeUrls",
        description:'',
        tags:''
    });

    a({
        id:1053,
        title:"TInputPeerNotifyEventsEmpty",
        content:"TInputPeerNotifyEventsEmpty",
        description:'',
        tags:''
    });

    a({
        id:1054,
        title:"RequestRpcDropAnswer",
        content:"RequestRpcDropAnswer",
        description:'',
        tags:''
    });

    a({
        id:1055,
        title:"TUpdateEncryption",
        content:"TUpdateEncryption",
        description:'',
        tags:''
    });

    a({
        id:1056,
        title:"IMessageMediaCommon",
        content:"IMessageMediaCommon",
        description:'',
        tags:''
    });

    a({
        id:1057,
        title:"RequestTogglePreHistoryHidden",
        content:"RequestTogglePreHistoryHidden",
        description:'',
        tags:''
    });

    a({
        id:1058,
        title:"TKeyboardButtonRow",
        content:"TKeyboardButtonRow",
        description:'',
        tags:''
    });

    a({
        id:1059,
        title:"RequestLogOut",
        content:"RequestLogOut",
        description:'',
        tags:''
    });

    a({
        id:1060,
        title:"TChannelDifferenceEmpty",
        content:"TChannelDifferenceEmpty",
        description:'',
        tags:''
    });

    a({
        id:1061,
        title:"TKeyboardButtonGame",
        content:"TKeyboardButtonGame",
        description:'',
        tags:''
    });

    a({
        id:1062,
        title:"TPrivacyValueDisallowUsers",
        content:"TPrivacyValueDisallowUsers",
        description:'',
        tags:''
    });

    a({
        id:1063,
        title:"TPaymentForm",
        content:"TPaymentForm",
        description:'',
        tags:''
    });

    a({
        id:1064,
        title:"TChatInviteEmpty",
        content:"TChatInviteEmpty",
        description:'',
        tags:''
    });

    a({
        id:1065,
        title:"TInputFileLocation",
        content:"TInputFileLocation",
        description:'',
        tags:''
    });

    a({
        id:1066,
        title:"TImportedContact",
        content:"TImportedContact",
        description:'',
        tags:''
    });

    a({
        id:1067,
        title:"TSendMessageGamePlayAction",
        content:"TSendMessageGamePlayAction",
        description:'',
        tags:''
    });

    a({
        id:1068,
        title:"TMessageEntityHashtag",
        content:"TMessageEntityHashtag",
        description:'',
        tags:''
    });

    a({
        id:1069,
        title:"RequestUpdateProfilePhoto",
        content:"RequestUpdateProfilePhoto",
        description:'',
        tags:''
    });

    a({
        id:1070,
        title:"IResPQ",
        content:"IResPQ",
        description:'',
        tags:''
    });

    a({
        id:1071,
        title:"IBotCommand",
        content:"IBotCommand",
        description:'',
        tags:''
    });

    a({
        id:1072,
        title:"RequestGetFullUser",
        content:"RequestGetFullUser",
        description:'',
        tags:''
    });

    a({
        id:1073,
        title:"RequestSetStickers",
        content:"RequestSetStickers",
        description:'',
        tags:''
    });

    a({
        id:1074,
        title:"RequestSendEncrypted",
        content:"RequestSendEncrypted",
        description:'',
        tags:''
    });

    a({
        id:1075,
        title:"IStickerPack",
        content:"IStickerPack",
        description:'',
        tags:''
    });

    a({
        id:1076,
        title:"IInputPaymentCredentials",
        content:"IInputPaymentCredentials",
        description:'',
        tags:''
    });

    a({
        id:1077,
        title:"TReplyKeyboardForceReply",
        content:"TReplyKeyboardForceReply",
        description:'',
        tags:''
    });

    a({
        id:1078,
        title:"TContact",
        content:"TContact",
        description:'',
        tags:''
    });

    a({
        id:1079,
        title:"TPageBlockDivider",
        content:"TPageBlockDivider",
        description:'',
        tags:''
    });

    a({
        id:1080,
        title:"RequestGetChannelDifference",
        content:"RequestGetChannelDifference",
        description:'',
        tags:''
    });

    a({
        id:1081,
        title:"RequestSearch",
        content:"RequestSearch",
        description:'',
        tags:''
    });

    a({
        id:1082,
        title:"TExportedMessageLink",
        content:"TExportedMessageLink",
        description:'',
        tags:''
    });

    a({
        id:1083,
        title:"TInputBotInlineMessageText",
        content:"TInputBotInlineMessageText",
        description:'',
        tags:''
    });

    a({
        id:1084,
        title:"RequestGetAttachedStickers",
        content:"RequestGetAttachedStickers",
        description:'',
        tags:''
    });

    a({
        id:1085,
        title:"RequestSetInlineBotResults",
        content:"RequestSetInlineBotResults",
        description:'',
        tags:''
    });

    a({
        id:1086,
        title:"TSentCodeTypeCall",
        content:"TSentCodeTypeCall",
        description:'',
        tags:''
    });

    a({
        id:1087,
        title:"TTopPeersNotModified",
        content:"TTopPeersNotModified",
        description:'',
        tags:''
    });

    a({
        id:1088,
        title:"TPeerDialogs",
        content:"TPeerDialogs",
        description:'',
        tags:''
    });

    a({
        id:1089,
        title:"TFileJpeg",
        content:"TFileJpeg",
        description:'',
        tags:''
    });

    a({
        id:1090,
        title:"TMaskCoords",
        content:"TMaskCoords",
        description:'',
        tags:''
    });

    a({
        id:1091,
        title:"TDifferenceTooLong",
        content:"TDifferenceTooLong",
        description:'',
        tags:''
    });

    a({
        id:1092,
        title:"TTrue",
        content:"TTrue",
        description:'',
        tags:''
    });

    a({
        id:1093,
        title:"TInputMessagePinned",
        content:"TInputMessagePinned",
        description:'',
        tags:''
    });

    a({
        id:1094,
        title:"IDifferenceCommon",
        content:"IDifferenceCommon",
        description:'',
        tags:''
    });

    a({
        id:1095,
        title:"TSendMessageRecordRoundAction",
        content:"TSendMessageRecordRoundAction",
        description:'',
        tags:''
    });

    a({
        id:1096,
        title:"IEncryptedChat",
        content:"IEncryptedChat",
        description:'',
        tags:''
    });

    a({
        id:1097,
        title:"TPageBlockPreformatted",
        content:"TPageBlockPreformatted",
        description:'',
        tags:''
    });

    a({
        id:1098,
        title:"RequestSaveCallDebug",
        content:"RequestSaveCallDebug",
        description:'',
        tags:''
    });

    a({
        id:1099,
        title:"ITopPeers",
        content:"ITopPeers",
        description:'',
        tags:''
    });

    a({
        id:1100,
        title:"TChannelAdminLogEventActionParticipantJoin",
        content:"TChannelAdminLogEventActionParticipantJoin",
        description:'',
        tags:''
    });

    a({
        id:1101,
        title:"RequestUpdateNotifySettings",
        content:"RequestUpdateNotifySettings",
        description:'',
        tags:''
    });

    a({
        id:1102,
        title:"IExportedAuthorization",
        content:"IExportedAuthorization",
        description:'',
        tags:''
    });

    a({
        id:1103,
        title:"RequestGetWallPapers",
        content:"RequestGetWallPapers",
        description:'',
        tags:''
    });

    a({
        id:1104,
        title:"TBlockedSlice",
        content:"TBlockedSlice",
        description:'',
        tags:''
    });

    a({
        id:1105,
        title:"IImportedContact",
        content:"IImportedContact",
        description:'',
        tags:''
    });

    a({
        id:1106,
        title:"TInputMessagesFilterRoundVideo",
        content:"TInputMessagesFilterRoundVideo",
        description:'',
        tags:''
    });

    a({
        id:1107,
        title:"TInputMessagesFilterPhotos",
        content:"TInputMessagesFilterPhotos",
        description:'',
        tags:''
    });

    a({
        id:1108,
        title:"IInputBotInlineResult",
        content:"IInputBotInlineResult",
        description:'',
        tags:''
    });

    a({
        id:1109,
        title:"IPhotoSizeCommon",
        content:"IPhotoSizeCommon",
        description:'',
        tags:''
    });

    a({
        id:1110,
        title:"TChannelParticipantsRecent",
        content:"TChannelParticipantsRecent",
        description:'',
        tags:''
    });

    a({
        id:1111,
        title:"TWebPageEmpty",
        content:"TWebPageEmpty",
        description:'',
        tags:''
    });

    a({
        id:1112,
        title:"RequestGetAppUpdate",
        content:"RequestGetAppUpdate",
        description:'',
        tags:''
    });

    a({
        id:1113,
        title:"TStickerSet",
        content:"TStickerSet",
        description:'',
        tags:''
    });

    a({
        id:1114,
        title:"TDocumentAttributeVideo",
        content:"TDocumentAttributeVideo",
        description:'',
        tags:''
    });

    a({
        id:1115,
        title:"RequestSendEncryptedService",
        content:"RequestSendEncryptedService",
        description:'',
        tags:''
    });

    a({
        id:1116,
        title:"TInputPaymentCredentialsAndroidPay",
        content:"TInputPaymentCredentialsAndroidPay",
        description:'',
        tags:''
    });

    a({
        id:1117,
        title:"IChat",
        content:"IChat",
        description:'',
        tags:''
    });

    a({
        id:1118,
        title:"RequestSendChangePhoneCode",
        content:"RequestSendChangePhoneCode",
        description:'',
        tags:''
    });

    a({
        id:1119,
        title:"RequestSearchGlobal",
        content:"RequestSearchGlobal",
        description:'',
        tags:''
    });

    a({
        id:1120,
        title:"RequestChangePhone",
        content:"RequestChangePhone",
        description:'',
        tags:''
    });

    a({
        id:1121,
        title:"RequestInvokeWithoutUpdates",
        content:"RequestInvokeWithoutUpdates",
        description:'',
        tags:''
    });

    a({
        id:1122,
        title:"TInputPrivacyValueAllowUsers",
        content:"TInputPrivacyValueAllowUsers",
        description:'',
        tags:''
    });

    a({
        id:1123,
        title:"TUpdateChatParticipantAdmin",
        content:"TUpdateChatParticipantAdmin",
        description:'',
        tags:''
    });

    a({
        id:1124,
        title:"TMessageEntityCode",
        content:"TMessageEntityCode",
        description:'',
        tags:''
    });

    a({
        id:1125,
        title:"TSentCodeTypeApp",
        content:"TSentCodeTypeApp",
        description:'',
        tags:''
    });

    a({
        id:1126,
        title:"TPhoneCall",
        content:"TPhoneCall",
        description:'',
        tags:''
    });

    a({
        id:1127,
        title:"TChatParticipantsForbidden",
        content:"TChatParticipantsForbidden",
        description:'',
        tags:''
    });

    a({
        id:1128,
        title:"TSendMessageGeoLocationAction",
        content:"TSendMessageGeoLocationAction",
        description:'',
        tags:''
    });

    a({
        id:1129,
        title:"TPhoneCallDiscarded",
        content:"TPhoneCallDiscarded",
        description:'',
        tags:''
    });

    a({
        id:1130,
        title:"TFoundStickerSets",
        content:"TFoundStickerSets",
        description:'',
        tags:''
    });

    a({
        id:1131,
        title:"TTopPeerCategoryGroups",
        content:"TTopPeerCategoryGroups",
        description:'',
        tags:''
    });

    a({
        id:1132,
        title:"RequestSetGameScore",
        content:"RequestSetGameScore",
        description:'',
        tags:''
    });

    a({
        id:1133,
        title:"IRecentMeUrl",
        content:"IRecentMeUrl",
        description:'',
        tags:''
    });

    a({
        id:1134,
        title:"RequestLeaveChannel",
        content:"RequestLeaveChannel",
        description:'',
        tags:''
    });

    a({
        id:1135,
        title:"TRecentMeUrlChatInvite",
        content:"TRecentMeUrlChatInvite",
        description:'',
        tags:''
    });

    a({
        id:1136,
        title:"TFilePng",
        content:"TFilePng",
        description:'',
        tags:''
    });

    a({
        id:1137,
        title:"TPagePart",
        content:"TPagePart",
        description:'',
        tags:''
    });

    a({
        id:1138,
        title:"TUserStatusEmpty",
        content:"TUserStatusEmpty",
        description:'',
        tags:''
    });

    a({
        id:1139,
        title:"RequestGetTopPeers",
        content:"RequestGetTopPeers",
        description:'',
        tags:''
    });

    a({
        id:1140,
        title:"RequestResetTopPeerRating",
        content:"RequestResetTopPeerRating",
        description:'',
        tags:''
    });

    a({
        id:1141,
        title:"TRpcAnswerDroppedRunning",
        content:"TRpcAnswerDroppedRunning",
        description:'',
        tags:''
    });

    a({
        id:1142,
        title:"RequestInvokeAfterMsg",
        content:"RequestInvokeAfterMsg",
        description:'',
        tags:''
    });

    a({
        id:1143,
        title:"RequestSendScreenshotNotification",
        content:"RequestSendScreenshotNotification",
        description:'',
        tags:''
    });

    a({
        id:1144,
        title:"RequestGetPeerSettings",
        content:"RequestGetPeerSettings",
        description:'',
        tags:''
    });

    a({
        id:1145,
        title:"RequestGetCommonChats",
        content:"RequestGetCommonChats",
        description:'',
        tags:''
    });

    a({
        id:1146,
        title:"TPaymentReceipt",
        content:"TPaymentReceipt",
        description:'',
        tags:''
    });

    a({
        id:1147,
        title:"IMessageEntity",
        content:"IMessageEntity",
        description:'',
        tags:''
    });

    a({
        id:1148,
        title:"TChatForbidden",
        content:"TChatForbidden",
        description:'',
        tags:''
    });

    a({
        id:1149,
        title:"IMessageRange",
        content:"IMessageRange",
        description:'',
        tags:''
    });

    a({
        id:1150,
        title:"RequestReport",
        content:"RequestReport",
        description:'',
        tags:''
    });

    a({
        id:1151,
        title:"RequestGetFavedStickers",
        content:"RequestGetFavedStickers",
        description:'',
        tags:''
    });

    a({
        id:1152,
        title:"RequestInvokeWithLayer",
        content:"RequestInvokeWithLayer",
        description:'',
        tags:''
    });

    a({
        id:1153,
        title:"TPhotoSizeEmpty",
        content:"TPhotoSizeEmpty",
        description:'',
        tags:''
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageUploadVideoAction',
        title:"TSendMessageUploadVideoAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueAllowUsers',
        title:"TPrivacyValueAllowUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPaymentCredentialsApplePay',
        title:"TInputPaymentCredentialsApplePay",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestStartBot',
        title:"RequestStartBot",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryBotsPM',
        title:"TTopPeerCategoryBotsPM",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/IFound',
        title:"IFound",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TChannelMessages',
        title:"TChannelMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestSaveFilePart',
        title:"RequestSaveFilePart",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterVideo',
        title:"TInputMessagesFilterVideo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPaymentCharge',
        title:"IPaymentCharge",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotCommand',
        title:"TBotCommand",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IAuthorizations',
        title:"IAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/IPhoneCall',
        title:"IPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInlineBotSwitchPM',
        title:"IInlineBotSwitchPM",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaInvoice',
        title:"TMessageMediaInvoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatesCombined',
        title:"TUpdatesCombined",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestReadMessageContents',
        title:"RequestReadMessageContents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TGeoPoint',
        title:"TGeoPoint",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPeerCommon',
        title:"IInputPeerCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IWebPageCommon',
        title:"IWebPageCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFoundGifCached',
        title:"TFoundGifCached",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestGetCdnFile',
        title:"RequestGetCdnFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetInlineGameScore',
        title:"RequestSetInlineGameScore",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatParticipantAdmin',
        title:"TChatParticipantAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/IBlocked',
        title:"IBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaPhoto',
        title:"TMessageMediaPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TChannelDifference',
        title:"TChannelDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestSetAccountTTL',
        title:"RequestSetAccountTTL",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/IChannelDifference',
        title:"IChannelDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebDocumentNoProxy',
        title:"TWebDocumentNoProxy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileMp4',
        title:"TFileMp4",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDialog',
        title:"TDialog",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelBannedRights',
        title:"TChannelBannedRights",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IPassword',
        title:"IPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TConfigSimple',
        title:"TConfigSimple",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TVector_1',
        title:"TVector<T>",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadChannelInbox',
        title:"TUpdateReadChannelInbox",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDestroySessionNone',
        title:"TDestroySessionNone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateFavedStickers',
        title:"TUpdateFavedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestAcceptCall',
        title:"RequestAcceptCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateRecentStickers',
        title:"TUpdateRecentStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TPassword',
        title:"TPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageMediaAuto',
        title:"TInputBotInlineMessageMediaAuto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRichText',
        title:"IRichText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBotInlineMessage',
        title:"IBotInlineMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestSetPrivacy',
        title:"RequestSetPrivacy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestDeleteUserHistory',
        title:"RequestDeleteUserHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLabeledPrice',
        title:"TLabeledPrice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDestroyAuthKeyFail',
        title:"TDestroyAuthKeyFail",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerChat',
        title:"TPeerChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPage',
        title:"IPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageUploadPhotoAction',
        title:"TSendMessageUploadPhotoAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonCallback',
        title:"TKeyboardButtonCallback",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IReplyMarkup',
        title:"IReplyMarkup",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterMusic',
        title:"TInputMessagesFilterMusic",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInvoice',
        title:"IInvoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestCancelCode',
        title:"RequestCancelCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaContact',
        title:"TInputMediaContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestSaveAppLog',
        title:"RequestSaveAppLog",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TAuthorizations',
        title:"TAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallEmpty',
        title:"TPhoneCallEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSearchGifs',
        title:"RequestSearchGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueDisallowAll',
        title:"TPrivacyValueDisallowAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFilePartial',
        title:"TFilePartial",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueAllowAll',
        title:"TInputPrivacyValueAllowAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgNewDetailedInfo',
        title:"TMsgNewDetailedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateStickerSets',
        title:"TUpdateStickerSets",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestReceivedCall',
        title:"RequestReceivedCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantBanned',
        title:"TChannelParticipantBanned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateContactLink',
        title:"TUpdateContactLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetPrivacy',
        title:"RequestGetPrivacy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateNewEncryptedMessage',
        title:"TUpdateNewEncryptedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TPaymentVerficationNeeded',
        title:"TPaymentVerficationNeeded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestImportChatInvite',
        title:"RequestImportChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionChangeTitle',
        title:"TChannelAdminLogEventActionChangeTitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IExportedChatInvite',
        title:"IExportedChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPhoneContact',
        title:"TInputPhoneContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputSingleMedia',
        title:"IInputSingleMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputFileBig',
        title:"TInputFileBig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestCheckChatInvite',
        title:"RequestCheckChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeer',
        title:"TTopPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockPullquote',
        title:"TPageBlockPullquote",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IPrivacyRules',
        title:"IPrivacyRules",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPaymentRequestedInfo',
        title:"IPaymentRequestedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockChannel',
        title:"TPageBlockChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEvent',
        title:"TChannelAdminLogEvent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestReqPq',
        title:"RequestReqPq",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TDhConfig',
        title:"TDhConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedChat',
        title:"TInputEncryptedChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBotInlineResult',
        title:"IBotInlineResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TServerDHParamsFail',
        title:"TServerDHParamsFail",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateDcOptions',
        title:"TUpdateDcOptions",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextUrl',
        title:"TTextUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestResetNotifySettings',
        title:"RequestResetNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestAcceptEncryption',
        title:"RequestAcceptEncryption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/ITmpPassword',
        title:"ITmpPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TAllStickers',
        title:"TAllStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IConfig',
        title:"IConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatePinnedDialogs',
        title:"TUpdatePinnedDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IEncryptedFile',
        title:"IEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateShort',
        title:"TUpdateShort",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyKeyPhoneCall',
        title:"TInputPrivacyKeyPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdateDeviceLocked',
        title:"RequestUpdateDeviceLocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotWebhookJSONQuery',
        title:"TUpdateBotWebhookJSONQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputReportReasonSpam',
        title:"TInputReportReasonSpam",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockSubheader',
        title:"TPageBlockSubheader",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterVoice',
        title:"TInputMessagesFilterVoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatJoinedByLink',
        title:"TMessageActionChatJoinedByLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetPinnedDialogs',
        title:"RequestGetPinnedDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TServerDHInnerData',
        title:"TServerDHInnerData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextBold',
        title:"TTextBold",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputNotifyPeer',
        title:"TInputNotifyPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetAuthorizations',
        title:"RequestGetAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageActionCommon',
        title:"IMessageActionCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterEmpty',
        title:"TInputMessagesFilterEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputAppEvent',
        title:"TInputAppEvent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextFixed',
        title:"TTextFixed",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactLinkContact',
        title:"TContactLinkContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDraftMessage',
        title:"IDraftMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputReportReasonOther',
        title:"TInputReportReasonOther",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetNotifySettings',
        title:"RequestGetNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputDocumentEmpty',
        title:"TInputDocumentEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocument',
        title:"TDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestReqDHParams',
        title:"RequestReqDHParams",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPeerSettings',
        title:"IPeerSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestJoinChannel',
        title:"RequestJoinChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateDraftMessage',
        title:"TUpdateDraftMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeHasStickers',
        title:"TDocumentAttributeHasStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IKeyboardButtonRow',
        title:"IKeyboardButtonRow",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestGetFileHashes',
        title:"RequestGetFileHashes",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDestroySessionRes',
        title:"IDestroySessionRes",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/ISentEncryptedMessage',
        title:"ISentEncryptedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestEditChatTitle',
        title:"RequestEditChatTitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaGeoPoint',
        title:"TInputMediaGeoPoint",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetAdminLog',
        title:"RequestGetAdminLog",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IStickerSetCovered',
        title:"IStickerSetCovered",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDataJSON',
        title:"TDataJSON",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageMediaGeo',
        title:"TInputBotInlineMessageMediaGeo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFavedStickers',
        title:"TFavedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelMessagesFilter',
        title:"TChannelMessagesFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateNewStickerSet',
        title:"TUpdateNewStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPopularContact',
        title:"IPopularContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactLinkNone',
        title:"TContactLinkNone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestDeleteContact',
        title:"RequestDeleteContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaGame',
        title:"TInputMediaGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputNotifyPeer',
        title:"IInputNotifyPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRsaPublicKey',
        title:"TRsaPublicKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockEmbed',
        title:"TPageBlockEmbed",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestBlock',
        title:"RequestBlock",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputWebFileLocation',
        title:"IInputWebFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserStatus',
        title:"TUpdateUserStatus",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageTypingAction',
        title:"TSendMessageTypingAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/IWebFile',
        title:"IWebFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUpdates',
        title:"IUpdates",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebDocument',
        title:"TWebDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatPhoto',
        title:"IChatPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputGeoPoint',
        title:"TInputGeoPoint",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TChats',
        title:"TChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/ISavedInfo',
        title:"ISavedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/IAppUpdate',
        title:"IAppUpdate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdatePasswordSettings',
        title:"RequestUpdatePasswordSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestGetPaymentForm',
        title:"RequestGetPaymentForm",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantCreator',
        title:"TChannelParticipantCreator",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotPrecheckoutQuery',
        title:"TUpdateBotPrecheckoutQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityTextUrl',
        title:"TMessageEntityTextUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPeer',
        title:"IPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestCreateChat',
        title:"RequestCreateChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestGetContacts',
        title:"RequestGetContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateEncryptedMessagesRead',
        title:"TUpdateEncryptedMessagesRead",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateEditChannelMessage',
        title:"TUpdateEditChannelMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLangPackStringPluralized',
        title:"TLangPackStringPluralized",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionUpdatePinned',
        title:"TChannelAdminLogEventActionUpdatePinned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestResetWebAuthorizations',
        title:"RequestResetWebAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TCheckedPhone',
        title:"TCheckedPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReceivedMessages',
        title:"RequestReceivedMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IWebAuthorizations',
        title:"IWebAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityEmail',
        title:"TMessageEntityEmail",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsKicked',
        title:"TChannelParticipantsKicked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IMessages',
        title:"IMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockCollage',
        title:"TPageBlockCollage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestResendCode',
        title:"RequestResendCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatParticipant',
        title:"TChatParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterMyMentions',
        title:"TInputMessagesFilterMyMentions",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputChatUploadedPhoto',
        title:"TInputChatUploadedPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadChannelOutbox',
        title:"TUpdateReadChannelOutbox",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contest/RequestSaveDeveloperInfo',
        title:"RequestSaveDeveloperInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestGetCdnFileHashes',
        title:"RequestGetCdnFileHashes",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedFileBigUploaded',
        title:"TInputEncryptedFileBigUploaded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallDiscardReasonBusy',
        title:"TPhoneCallDiscardReasonBusy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestResetSaved',
        title:"RequestResetSaved",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetRecentLocations',
        title:"RequestGetRecentLocations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetDhConfig',
        title:"RequestGetDhConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestGetCallConfig',
        title:"RequestGetCallConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateInlineBotCallbackQuery',
        title:"TUpdateInlineBotCallbackQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendMessage',
        title:"RequestSendMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/ILink',
        title:"ILink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedFileEmpty',
        title:"TEncryptedFileEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueAllowContacts',
        title:"TInputPrivacyValueAllowContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextItalic',
        title:"TTextItalic",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallAccepted',
        title:"TPhoneCallAccepted",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestSignUp',
        title:"RequestSignUp",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineResultPhoto',
        title:"TInputBotInlineResultPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputDialogPeer',
        title:"IInputDialogPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetAllDrafts',
        title:"RequestGetAllDrafts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedChatRequested',
        title:"TEncryptedChatRequested",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockPhoto',
        title:"TPageBlockPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestSetBotUpdatesStatus',
        title:"RequestSetBotUpdatesStatus",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityMentionName',
        title:"TMessageEntityMentionName",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgResendReq',
        title:"TMsgResendReq",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestReadHistory',
        title:"RequestReadHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPaymentCredentialsSaved',
        title:"TInputPaymentCredentialsSaved",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionScreenshotTaken',
        title:"TMessageActionScreenshotTaken",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/IPaymentResult',
        title:"IPaymentResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestConfirmPhone',
        title:"RequestConfirmPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBoolFalse',
        title:"TBoolFalse",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/TChannelParticipantsNotModified',
        title:"TChannelParticipantsNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPrivacyRule',
        title:"IPrivacyRule",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestForwardMessages',
        title:"RequestForwardMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputDocument',
        title:"TInputDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPQInnerData',
        title:"TPQInnerData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IChats',
        title:"IChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusOffline',
        title:"TUserStatusOffline",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetDialogs',
        title:"RequestGetDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageCommon',
        title:"IMessageCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/ISupport',
        title:"ISupport",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserEmpty',
        title:"TUserEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerChat',
        title:"TInputPeerChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetMessages',
        title:"RequestGetMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendMultiMedia',
        title:"RequestSendMultiMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterDocument',
        title:"TInputMessagesFilterDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TTermsOfService',
        title:"TTermsOfService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallDiscardReasonHangup',
        title:"TPhoneCallDiscardReasonHangup",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReportSpam',
        title:"RequestReportSpam",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionPhoneCall',
        title:"TMessageActionPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaPhotoExternal',
        title:"TInputMediaPhotoExternal",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMessageMediaAuto',
        title:"TBotInlineMessageMediaAuto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputEncryptedChat',
        title:"IInputEncryptedChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReadMessageContents',
        title:"RequestReadMessageContents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelFull',
        title:"TChannelFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsSearch',
        title:"TChannelParticipantsSearch",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityPhone',
        title:"TMessageEntityPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateMessageID',
        title:"TUpdateMessageID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPaymentCharge',
        title:"TPaymentCharge",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/ISentCodeType',
        title:"ISentCodeType",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestDeleteMessages',
        title:"RequestDeleteMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/IPaymentReceipt',
        title:"IPaymentReceipt",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionParticipantToggleBan',
        title:"TChannelAdminLogEventActionParticipantToggleBan",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/TChannelParticipant',
        title:"TChannelParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaUploadedDocument',
        title:"TInputMediaUploadedDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/ISavedGifs',
        title:"ISavedGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionChangePhoto',
        title:"TChannelAdminLogEventActionChangePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateSavedGifs',
        title:"TUpdateSavedGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/ICdnFile',
        title:"ICdnFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/IChannelParticipants',
        title:"IChannelParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestDiscardCall',
        title:"RequestDiscardCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoneConnection',
        title:"IPhoneConnection",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestImportContacts',
        title:"RequestImportContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetParticipants',
        title:"RequestGetParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionPinMessage',
        title:"TMessageActionPinMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestDiscardEncryption',
        title:"RequestDiscardEncryption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUserStatus',
        title:"IUserStatus",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoneCallProtocol',
        title:"IPhoneCallProtocol",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestUpdateUsername',
        title:"RequestUpdateUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Bots/RequestSendCustomRequest',
        title:"RequestSendCustomRequest",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TResolvedPeer',
        title:"TResolvedPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannel',
        title:"TUpdateChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputNotifyChats',
        title:"TInputNotifyChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaUploadedPhoto',
        title:"TInputMediaUploadedPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Common.Extensions/NettyExtensions',
        title:"NettyExtensions",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNull',
        title:"TNull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockCover',
        title:"TPageBlockCover",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatInviteAlready',
        title:"TChatInviteAlready",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatFull',
        title:"IChatFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallRequested',
        title:"TPhoneCallRequested",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestReportSpam',
        title:"RequestReportSpam",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRecentMeUrlStickerSet',
        title:"TRecentMeUrlStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPeer',
        title:"IInputPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputGameID',
        title:"TInputGameID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFoundGif',
        title:"TFoundGif",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputReportReasonViolence',
        title:"TInputReportReasonViolence",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IFoundGif',
        title:"IFoundGif",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelWebPage',
        title:"TUpdateChannelWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMsgDetailedInfo',
        title:"IMsgDetailedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerEmpty',
        title:"TInputPeerEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPong',
        title:"IPong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSaveGif',
        title:"RequestSaveGif",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBadMsgNotification',
        title:"IBadMsgNotification",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonBuy',
        title:"TKeyboardButtonBuy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPaymentCredentials',
        title:"TInputPaymentCredentials",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestEditInlineBotMessage',
        title:"RequestEditInlineBotMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileGif',
        title:"TFileGif",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TInviteText',
        title:"TInviteText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineResult',
        title:"TBotInlineResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/ISentCode',
        title:"ISentCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryPhoneCalls',
        title:"TTopPeerCategoryPhoneCalls",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IStickerSetInstallResult',
        title:"IStickerSetInstallResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestRecoverPassword',
        title:"RequestRecoverPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/TChannelParticipants',
        title:"TChannelParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueAllowAll',
        title:"TPrivacyValueAllowAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatPhotoEmpty',
        title:"TChatPhotoEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageChooseContactAction',
        title:"TSendMessageChooseContactAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedFile',
        title:"TEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgsStateReq',
        title:"TMsgsStateReq",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUpdate',
        title:"IUpdate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TStickerSetMultiCovered',
        title:"TStickerSetMultiCovered",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputGameShortName',
        title:"TInputGameShortName",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterPhotoVideo',
        title:"TInputMessagesFilterPhotoVideo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetMessages',
        title:"RequestGetMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestToggleDialogPin',
        title:"RequestToggleDialogPin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageService',
        title:"TMessageService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ITopPeer',
        title:"ITopPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IStickerSet',
        title:"IStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestSetClientDHParams',
        title:"RequestSetClientDHParams",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextStrike',
        title:"TTextStrike",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetPassword',
        title:"RequestGetPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TSavedInfo',
        title:"TSavedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/RequestGetState',
        title:"RequestGetState",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TDifferenceEmpty',
        title:"TDifferenceEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestResetWebAuthorization',
        title:"RequestResetWebAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IChatFull',
        title:"IChatFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessage',
        title:"TMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFavedStickersNotModified',
        title:"TFavedStickersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetAccountTTL',
        title:"RequestGetAccountTTL",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestImportAuthorization',
        title:"RequestImportAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChat',
        title:"TChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/TAdminLogResults',
        title:"TAdminLogResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatFull',
        title:"TChatFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestImportCard',
        title:"RequestImportCard",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRecentMeUrlUnknown',
        title:"TRecentMeUrlUnknown",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestInstallStickerSet',
        title:"RequestInstallStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPhoneCall',
        title:"IInputPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/IState',
        title:"IState",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputEncryptedFile',
        title:"IInputEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestSendCode',
        title:"RequestSendCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelBannedRights',
        title:"IChannelBannedRights",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/RequestDeletePhotos',
        title:"RequestDeletePhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatDeleteUser',
        title:"TMessageActionChatDeleteUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWallPaperSolid',
        title:"TWallPaperSolid",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/THighScores',
        title:"THighScores",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Serialization/Serializer',
        title:"Serializer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRecentMeUrlChat',
        title:"TRecentMeUrlChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TMessagesNotModified',
        title:"TMessagesNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestSetCallRating',
        title:"RequestSetCallRating",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSaveDraft',
        title:"RequestSaveDraft",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChannelCreate',
        title:"TMessageActionChannelCreate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueAllowContacts',
        title:"TPrivacyValueAllowContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestToggleSignatures',
        title:"RequestToggleSignatures",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatInvite',
        title:"IChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IFoundGifs',
        title:"IFoundGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestInvokeAfterMsgs',
        title:"RequestInvokeAfterMsgs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDialog',
        title:"IDialog",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IBotCallbackAnswer',
        title:"IBotCallbackAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ISetClientDHParamsAnswer',
        title:"ISetClientDHParamsAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TPasswordRecovery',
        title:"TPasswordRecovery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockBlockquote',
        title:"TPageBlockBlockquote",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerNotifyEventsEmpty',
        title:"TPeerNotifyEventsEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgContainer',
        title:"TMsgContainer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMessageMediaGeo',
        title:"TBotInlineMessageMediaGeo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionParticipantToggleAdmin',
        title:"TChannelAdminLogEventActionParticipantToggleAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TCdnConfig',
        title:"TCdnConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPong',
        title:"TPong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaPhoto',
        title:"TInputMediaPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IEncryptedChatCommon',
        title:"IEncryptedChatCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestInitConnection',
        title:"RequestInitConnection",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateShortChatMessage',
        title:"TUpdateShortChatMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IAccountDaysTTL',
        title:"IAccountDaysTTL",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/TWebFile',
        title:"TWebFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetParticipant',
        title:"RequestGetParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetTmpPassword',
        title:"RequestGetTmpPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestEditMessage',
        title:"RequestEditMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ILabeledPrice',
        title:"ILabeledPrice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/IPhoto',
        title:"IPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPostAddress',
        title:"TPostAddress",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestRequestPasswordRecovery',
        title:"RequestRequestPasswordRecovery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerSelf',
        title:"TInputPeerSelf",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPrivacyKey',
        title:"IInputPrivacyKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMediaResult',
        title:"TBotInlineMediaResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueDisallowContacts',
        title:"TPrivacyValueDisallowContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputMessage',
        title:"IInputMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBool',
        title:"IBool",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/THighScore',
        title:"THighScore",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickeredMediaPhoto',
        title:"TInputStickeredMediaPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TAppUpdate',
        title:"TAppUpdate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatParticipants',
        title:"TChatParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/RequestGetDifference',
        title:"RequestGetDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPeerNotifySettings',
        title:"IInputPeerNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IWallPaper',
        title:"IWallPaper",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebPageNotModified',
        title:"TWebPageNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IDialogs',
        title:"IDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatInviteExported',
        title:"TChatInviteExported",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusLastWeek',
        title:"TUserStatusLastWeek",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDestroyAuthKeyOk',
        title:"TDestroyAuthKeyOk",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestAddChatUser',
        title:"RequestAddChatUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TBotCallbackAnswer',
        title:"TBotCallbackAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserFull',
        title:"TUserFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineResultGame',
        title:"TInputBotInlineResultGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetInlineBotResults',
        title:"RequestGetInlineBotResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextPlain',
        title:"TTextPlain",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionToggleInvites',
        title:"TChannelAdminLogEventActionToggleInvites",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaEmpty',
        title:"TInputMediaEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputWebDocument',
        title:"IInputWebDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUnregisterDevice',
        title:"RequestUnregisterDevice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPaymentSavedCredentials',
        title:"IPaymentSavedCredentials",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDialogPeer',
        title:"IDialogPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetPeerDialogs',
        title:"RequestGetPeerDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFutureSalts',
        title:"TFutureSalts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserTyping',
        title:"TUpdateUserTyping",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetTyping',
        title:"RequestSetTyping",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TAffectedHistory',
        title:"TAffectedHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyKeyChatInvite',
        title:"TInputPrivacyKeyChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerNotifySettingsEmpty',
        title:"TPeerNotifySettingsEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestDropTempAuthKeys',
        title:"RequestDropTempAuthKeys",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReceivedQueue',
        title:"RequestReceivedQueue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityMention',
        title:"TMessageEntityMention",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDraftMessageEmpty',
        title:"TDraftMessageEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestExportAuthorization',
        title:"RequestExportAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReadMentions',
        title:"RequestReadMentions",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonSwitchInline',
        title:"TKeyboardButtonSwitchInline",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TAffectedMessages',
        title:"TAffectedMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Stickers/RequestAddStickerToSet',
        title:"RequestAddStickerToSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterUrl',
        title:"TInputMessagesFilterUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactLinkHasPhone',
        title:"TContactLinkHasPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestDestroySession',
        title:"RequestDestroySession",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetFullChat',
        title:"RequestGetFullChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserName',
        title:"TUpdateUserName",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Stickers/RequestCreateStickerSet',
        title:"RequestCreateStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotInlineQuery',
        title:"TUpdateBotInlineQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestToggleInvites',
        title:"RequestToggleInvites",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileMov',
        title:"TFileMov",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaGifExternal',
        title:"TInputMediaGifExternal",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPaymentRequestedInfo',
        title:"TPaymentRequestedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetNearestDc',
        title:"RequestGetNearestDc",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestEditAbout',
        title:"RequestEditAbout",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadMessagesContents',
        title:"TUpdateReadMessagesContents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelReadMessagesContents',
        title:"TUpdateChannelReadMessagesContents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TServerDHParamsOk',
        title:"TServerDHParamsOk",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonRequestGeoLocation',
        title:"TKeyboardButtonRequestGeoLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChannelMigrateFrom',
        title:"TMessageActionChannelMigrateFrom",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReadEncryptedHistory',
        title:"RequestReadEncryptedHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Langpack/RequestGetDifference',
        title:"RequestGetDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetAppChangelog',
        title:"RequestGetAppChangelog",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestEditAdmin',
        title:"RequestEditAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeSticker',
        title:"TDocumentAttributeSticker",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestDeleteContacts',
        title:"RequestDeleteContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFeaturedStickers',
        title:"TFeaturedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetWebAuthorizations',
        title:"RequestGetWebAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestBindTempAuthKey',
        title:"RequestBindTempAuthKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TFound',
        title:"TFound",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestExportInvite',
        title:"RequestExportInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TgZipPacked',
        title:"TgZipPacked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetMessagesViews',
        title:"RequestGetMessagesViews",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButton',
        title:"TKeyboardButton",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBadServerSalt',
        title:"TBadServerSalt",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerNotifySettings',
        title:"TPeerNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantAdmin',
        title:"TChannelParticipantAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelAdminLogEventAction',
        title:"IChannelAdminLogEventAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TCodeTypeCall',
        title:"TCodeTypeCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/IChannelDifferenceCommon',
        title:"IChannelDifferenceCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IPeerDialogs',
        title:"IPeerDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestRequestEncryption',
        title:"RequestRequestEncryption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPrivacyKey',
        title:"IPrivacyKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/TFile',
        title:"TFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityBotCommand',
        title:"TMessageEntityBotCommand",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputEncryptedFileCommon',
        title:"IInputEncryptedFileCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatMigrateTo',
        title:"TMessageActionChatMigrateTo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetGameHighScores',
        title:"RequestGetGameHighScores",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TSavedGifsNotModified',
        title:"TSavedGifsNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityCashtag',
        title:"TMessageEntityCashtag",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestFaveSticker',
        title:"RequestFaveSticker",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionHistoryClear',
        title:"TMessageActionHistoryClear",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetRecentStickers',
        title:"RequestGetRecentStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IMessageEditData',
        title:"IMessageEditData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetHistory',
        title:"RequestGetHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TSupport',
        title:"TSupport",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotInlineSend',
        title:"TUpdateBotInlineSend",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/IDifference',
        title:"IDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRpcDropAnswer',
        title:"IRpcDropAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputChatPhoto',
        title:"IInputChatPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestReportPeer',
        title:"RequestReportPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoneCall',
        title:"IPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatDeletePhoto',
        title:"TMessageActionChatDeletePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDialogPeer',
        title:"TDialogPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IWebDocument',
        title:"IWebDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockAuthorDate',
        title:"TPageBlockAuthorDate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestCheckPassword',
        title:"RequestCheckPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IGeoPoint',
        title:"IGeoPoint",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatParticipants',
        title:"IChatParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IArchivedStickers',
        title:"IArchivedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDcOption',
        title:"TDcOption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionPaymentSent',
        title:"TMessageActionPaymentSent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestReqPqMulti',
        title:"RequestReqPqMulti",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelAdminLogEvent',
        title:"IChannelAdminLogEvent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReadHistory',
        title:"RequestReadHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestUninstallStickerSet',
        title:"RequestUninstallStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryChannels',
        title:"TTopPeerCategoryChannels",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdateStatus',
        title:"RequestUpdateStatus",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TBlocked',
        title:"TBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineResult',
        title:"TInputBotInlineResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/IPhotos',
        title:"IPhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TTopPeers',
        title:"TTopPeers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhotoSize',
        title:"TPhotoSize",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatParticipant',
        title:"IChatParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TIpPort',
        title:"TIpPort",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputBotInlineMessageID',
        title:"IInputBotInlineMessageID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestSendInvites',
        title:"RequestSendInvites",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionChangeAbout',
        title:"TChannelAdminLogEventActionChangeAbout",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaInvoice',
        title:"TInputMediaInvoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionEditMessage',
        title:"TChannelAdminLogEventActionEditMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TSentCode',
        title:"TSentCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TStickerSetCovered',
        title:"TStickerSetCovered",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPostAddress',
        title:"IPostAddress",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventsFilter',
        title:"TChannelAdminLogEventsFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputStickeredMedia',
        title:"IInputStickeredMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IServerDHParams',
        title:"IServerDHParams",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateEditMessage',
        title:"TUpdateEditMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IFavedStickers',
        title:"IFavedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSaveRecentSticker',
        title:"RequestSaveRecentSticker",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetBotShippingResults',
        title:"RequestSetBotShippingResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputMedia',
        title:"IInputMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgDetailedInfo',
        title:"TMsgDetailedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestEditChatPhoto',
        title:"RequestEditChatPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInlineBotSwitchPM',
        title:"TInlineBotSwitchPM",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IWebAuthorization',
        title:"IWebAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestMigrateChat',
        title:"RequestMigrateChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetWebPage',
        title:"RequestGetWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TCdnPublicKey',
        title:"TCdnPublicKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelAdminLogEventsFilter',
        title:"IChannelAdminLogEventsFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityItalic',
        title:"TMessageEntityItalic",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IFutureSalts',
        title:"IFutureSalts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatCreate',
        title:"TMessageActionChatCreate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMaskCoords',
        title:"IMaskCoords",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBoolTrue',
        title:"TBoolTrue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContainerMessage',
        title:"TContainerMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyKeyStatusTimestamp',
        title:"TPrivacyKeyStatusTimestamp",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterRoundVoice',
        title:"TInputMessagesFilterRoundVoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IFeaturedStickers',
        title:"IFeaturedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputUserEmpty',
        title:"TInputUserEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TConfig',
        title:"TConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockParagraph',
        title:"TPageBlockParagraph",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgsStateInfo',
        title:"TMsgsStateInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerUser',
        title:"TInputPeerUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatParticipants',
        title:"TUpdateChatParticipants",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IReportReason',
        title:"IReportReason",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelTooLong',
        title:"TUpdateChannelTooLong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TStickerPack',
        title:"TStickerPack",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestConfirmCall',
        title:"RequestConfirmCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedFileLocation',
        title:"TInputEncryptedFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetBotPrecheckoutResults',
        title:"RequestSetBotPrecheckoutResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextEmpty',
        title:"TTextEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TPasswordSettings',
        title:"TPasswordSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessageEntityMentionName',
        title:"TInputMessageEntityMentionName",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/ICheckedPhone',
        title:"ICheckedPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRpcAnswerUnknown',
        title:"TRpcAnswerUnknown",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPeerNotifyEvents',
        title:"IInputPeerNotifyEvents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageMediaVenue',
        title:"TInputBotInlineMessageMediaVenue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendInlineBotResult',
        title:"RequestSendInlineBotResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessage',
        title:"IMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestExportChatInvite',
        title:"RequestExportChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPageBlock',
        title:"IPageBlock",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ISendMessageAction',
        title:"ISendMessageAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusLastMonth',
        title:"TUserStatusLastMonth",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserProfilePhoto',
        title:"TUserProfilePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterContacts',
        title:"TInputMessagesFilterContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TChatFull',
        title:"TChatFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedFileEmpty',
        title:"TInputEncryptedFileEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestEditChatAdmin',
        title:"RequestEditChatAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessagesFilter',
        title:"IMessagesFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Serialization.Attributes/BareTypeAttribute',
        title:"BareTypeAttribute",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestDeleteMessages',
        title:"RequestDeleteMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestDeleteAccount',
        title:"RequestDeleteAccount",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterGif',
        title:"TInputMessagesFilterGif",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestImportBotAuthorization',
        title:"RequestImportBotAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateDialogPinned',
        title:"TUpdateDialogPinned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhotoSize',
        title:"IPhotoSize",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhotoEmpty',
        title:"TPhotoEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Users/RequestGetUsers',
        title:"RequestGetUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatAddUser',
        title:"TMessageActionChatAddUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputContact',
        title:"IInputContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestSendConfirmPhoneCode',
        title:"RequestSendConfirmPhoneCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TArchivedStickers',
        title:"TArchivedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMessageMediaVenue',
        title:"TBotInlineMessageMediaVenue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IContact',
        title:"IContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetUnreadMentions',
        title:"RequestGetUnreadMentions",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsAdmins',
        title:"TChannelParticipantsAdmins",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/IAuthorization',
        title:"IAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedMessageService',
        title:"TEncryptedMessageService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPrivacyRule',
        title:"IInputPrivacyRule",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageGame',
        title:"TInputBotInlineMessageGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputNotifyUsers',
        title:"TInputNotifyUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRpcResult',
        title:"TRpcResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeFilename',
        title:"TDocumentAttributeFilename",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputDocumentFileLocation',
        title:"TInputDocumentFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TTmpPassword',
        title:"TTmpPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetSupport',
        title:"RequestGetSupport",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetSavedGifs',
        title:"RequestGetSavedGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaGeoLive',
        title:"TMessageMediaGeoLive",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFoundStickerSetsNotModified',
        title:"TFoundStickerSetsNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionParticipantLeave',
        title:"TChannelAdminLogEventActionParticipantLeave",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionChangeStickerSet',
        title:"TChannelAdminLogEventActionChangeStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatePtsChanged',
        title:"TUpdatePtsChanged",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdates',
        title:"TUpdates",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockSlideshow',
        title:"TPageBlockSlideshow",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputDocument',
        title:"IInputDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetChannels',
        title:"RequestGetChannels",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateEncryptedChatTyping',
        title:"TUpdateEncryptedChatTyping",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestClearRecentStickers',
        title:"RequestClearRecentStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IStickers',
        title:"IStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeAudio',
        title:"TDocumentAttributeAudio",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUser',
        title:"TUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaEmpty',
        title:"TMessageMediaEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageFull',
        title:"TPageFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyKeyChatInvite',
        title:"TPrivacyKeyChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/IFileType',
        title:"IFileType",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineResultDocument',
        title:"TInputBotInlineResultDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWallPaper',
        title:"TWallPaper",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestResetAuthorizations',
        title:"RequestResetAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueDisallowAll',
        title:"TInputPrivacyValueDisallowAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetBotCallbackAnswer',
        title:"RequestGetBotCallbackAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TGeoPointEmpty',
        title:"TGeoPointEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestExportMessageLink',
        title:"RequestExportMessageLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TDifference',
        title:"TDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotShippingQuery',
        title:"TUpdateBotShippingQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUserStatusCommon',
        title:"IUserStatusCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputUser',
        title:"TInputUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageRange',
        title:"TMessageRange",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileWebp',
        title:"TFileWebp",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUserProfilePhoto',
        title:"IUserProfilePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDestroyAuthKeyRes',
        title:"IDestroyAuthKeyRes",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Stickers/RequestChangeStickerPosition',
        title:"RequestChangeStickerPosition",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileMp3',
        title:"TFileMp3",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDocumentAttribute',
        title:"IDocumentAttribute",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TChatsSlice',
        title:"TChatsSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaUnsupported',
        title:"TMessageMediaUnsupported",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputDialogPeer',
        title:"TInputDialogPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageMedia',
        title:"IMessageMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestGetStatuses',
        title:"RequestGetStatuses",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageAction',
        title:"IMessageAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TSentCodeTypeSms',
        title:"TSentCodeTypeSms",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionBotAllowed',
        title:"TMessageActionBotAllowed",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IKeyboardButton',
        title:"IKeyboardButton",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChatCommon',
        title:"IChatCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFeaturedStickersNotModified',
        title:"TFeaturedStickersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockSubtitle',
        title:"TPageBlockSubtitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInfo',
        title:"TBotInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestEditTitle',
        title:"RequestEditTitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputSingleMedia',
        title:"TInputSingleMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestGetFile',
        title:"RequestGetFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TShippingOption',
        title:"TShippingOption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMessageText',
        title:"TBotInlineMessageText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageUploadRoundAction',
        title:"TSendMessageUploadRoundAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerNotifySettings',
        title:"TInputPeerNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDhGenRetry',
        title:"TDhGenRetry",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetArchivedStickers',
        title:"RequestGetArchivedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFileLocation',
        title:"TFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TSentEncryptedFile',
        title:"TSentEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockAnchor',
        title:"TPageBlockAnchor",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestToggleChatAdmins',
        title:"RequestToggleChatAdmins",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TGame',
        title:"TGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/IFile',
        title:"IFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerNotifyEventsAll',
        title:"TPeerNotifyEventsAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IEncryptedMessage',
        title:"IEncryptedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelParticipantsFilter',
        title:"IChannelParticipantsFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TBotResults',
        title:"TBotResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestEditPhoto',
        title:"RequestEditPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEmpty',
        title:"TMessageEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipant',
        title:"TChannelParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageID',
        title:"TInputBotInlineMessageID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaDocumentExternal',
        title:"TInputMediaDocumentExternal",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageCancelAction',
        title:"TSendMessageCancelAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestCheckPhone',
        title:"RequestCheckPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextConcat',
        title:"TTextConcat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNotifyPeer',
        title:"TNotifyPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetInviteText',
        title:"RequestGetInviteText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterGeo',
        title:"TInputMessagesFilterGeo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFileLocationUnavailable',
        title:"TFileLocationUnavailable",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeImageSize',
        title:"TDocumentAttributeImageSize",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TNoPassword',
        title:"TNoPassword",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IAffectedMessages',
        title:"IAffectedMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDraftMessage',
        title:"TDraftMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TReplyKeyboardMarkup',
        title:"TReplyKeyboardMarkup",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputGame',
        title:"IInputGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IAllStickers',
        title:"IAllStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestGetPaymentReceipt',
        title:"RequestGetPaymentReceipt",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputWebDocument',
        title:"TInputWebDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelForbidden',
        title:"TChannelForbidden",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerChannel',
        title:"TPeerChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputGeoPoint',
        title:"IInputGeoPoint",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBadMsgNotification',
        title:"TBadMsgNotification",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TStickerSetInstallResultSuccess',
        title:"TStickerSetInstallResultSuccess",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IFileLocation',
        title:"IFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityUrl',
        title:"TMessageEntityUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatParticipantAdd',
        title:"TUpdateChatParticipantAdd",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TLink',
        title:"TLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionDeleteMessage',
        title:"TChannelAdminLogEventActionDeleteMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestSaveBigFilePart',
        title:"RequestSaveBigFilePart",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestClearSavedInfo',
        title:"RequestClearSavedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsBots',
        title:"TChannelParticipantsBots",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetDocumentByHash',
        title:"RequestGetDocumentByHash",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterChatPhotos',
        title:"TInputMessagesFilterChatPhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TWebAuthorizations',
        title:"TWebAuthorizations",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/TCdnFileReuploadNeeded',
        title:"TCdnFileReuploadNeeded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallProtocol',
        title:"TPhoneCallProtocol",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLangPackStringDeleted',
        title:"TLangPackStringDeleted",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPhoto',
        title:"IInputPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionParticipantInvite',
        title:"TChannelAdminLogEventActionParticipantInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminRights',
        title:"TChannelAdminRights",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestCheckUsername',
        title:"RequestCheckUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TStickers',
        title:"TStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerNotifyEventsAll',
        title:"TInputPeerNotifyEventsAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TDifferenceSlice',
        title:"TDifferenceSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputUserSelf',
        title:"TInputUserSelf",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/ITermsOfService',
        title:"ITermsOfService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputReportReasonPornography',
        title:"TInputReportReasonPornography",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerChannel',
        title:"TInputPeerChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedMessage',
        title:"TEncryptedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TError',
        title:"TError",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TSentEncryptedMessage',
        title:"TSentEncryptedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Langpack/RequestGetLangPack',
        title:"RequestGetLangPack",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPhoneCall',
        title:"TInputPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetStickers',
        title:"RequestGetStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputFileLocation',
        title:"IInputFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IAffectedHistory',
        title:"IAffectedHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickeredMediaDocument',
        title:"TInputStickeredMediaDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputNotifyAll',
        title:"TInputNotifyAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatEmpty',
        title:"TChatEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/IPasswordRecovery',
        title:"IPasswordRecovery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelMessagesFilter',
        title:"IChannelMessagesFilter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetRecentMeUrls',
        title:"RequestGetRecentMeUrls",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TStickersNotModified',
        title:"TStickersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestResetAuthorization',
        title:"RequestResetAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestResolveUsername',
        title:"RequestResolveUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSearchStickerSets',
        title:"RequestSearchStickerSets",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPhoto',
        title:"TInputPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotWebhookJSON',
        title:"TUpdateBotWebhookJSON",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TChannelDifferenceTooLong',
        title:"TChannelDifferenceTooLong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/RequestGetUserPhotos',
        title:"RequestGetUserPhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TValidatedRequestedInfo',
        title:"TValidatedRequestedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TDhConfigNotModified',
        title:"TDhConfigNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserPhoto',
        title:"TUpdateUserPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterPhoneCalls',
        title:"TInputMessagesFilterPhoneCalls",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaGeo',
        title:"TMessageMediaGeo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageRecordVideoAction',
        title:"TSendMessageRecordVideoAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TState',
        title:"TState",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBotInfo',
        title:"IBotInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDocument',
        title:"IDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerUser',
        title:"TPeerUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDestroySessionOk',
        title:"TDestroySessionOk",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaWebPage',
        title:"TMessageMediaWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserBlocked',
        title:"TUpdateUserBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReorderStickerSets',
        title:"RequestReorderStickerSets",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonRequestPhone',
        title:"TKeyboardButtonRequestPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/Utils',
        title:"Utils",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IGame',
        title:"IGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetInlineGameHighScores',
        title:"RequestGetInlineGameHighScores",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateStickerSetsOrder',
        title:"TUpdateStickerSetsOrder",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IHighScore',
        title:"IHighScore",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockHeader',
        title:"TPageBlockHeader",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TExportedAuthorization',
        title:"TExportedAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IFoundStickerSets',
        title:"IFoundStickerSets",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockTitle',
        title:"TPageBlockTitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ILangPackDifference',
        title:"ILangPackDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestGetBlocked',
        title:"RequestGetBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/IResolvedPeer',
        title:"IResolvedPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionGameScore',
        title:"TMessageActionGameScore",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetWebPagePreview',
        title:"RequestGetWebPagePreview",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TNoAppUpdate',
        title:"TNoAppUpdate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFileHash',
        title:"TFileHash",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateNewMessage',
        title:"TUpdateNewMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TContactsNotModified',
        title:"TContactsNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDataJSON',
        title:"IDataJSON",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestRegisterDevice',
        title:"RequestRegisterDevice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputChannel',
        title:"IInputChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoneCallDiscardReason',
        title:"IPhoneCallDiscardReason",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatEditPhoto',
        title:"TMessageActionChatEditPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TSentCodeTypeFlashCall',
        title:"TSentCodeTypeFlashCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatesTooLong',
        title:"TUpdatesTooLong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestDeleteChatUser',
        title:"RequestDeleteChatUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TPaymentResult',
        title:"TPaymentResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TAccountDaysTTL',
        title:"TAccountDaysTTL",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPeerSettings',
        title:"TPeerSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatInvite',
        title:"TChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/INotifyPeer',
        title:"INotifyPeer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestEditBanned',
        title:"RequestEditBanned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IContactLink',
        title:"IContactLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPeerNotifySettings',
        title:"IPeerNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserProfilePhotoEmpty',
        title:"TUserProfilePhotoEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetBotCallbackAnswer',
        title:"RequestSetBotCallbackAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TBotInlineMessageMediaContact',
        title:"TBotInlineMessageMediaContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TRecentStickersNotModified',
        title:"TRecentStickersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/TPhoto',
        title:"TPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/IChannelParticipant',
        title:"IChannelParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IContactBlocked',
        title:"IContactBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IStickerSet',
        title:"IStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/RequestUploadProfilePhoto',
        title:"RequestUploadProfilePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockList',
        title:"TPageBlockList",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelMessagesFilterEmpty',
        title:"TChannelMessagesFilterEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TReplyKeyboardHide',
        title:"TReplyKeyboardHide",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TResPQ',
        title:"TResPQ",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IPasswordInputSettings',
        title:"IPasswordInputSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRpcAnswerDropped',
        title:"TRpcAnswerDropped",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextEmail',
        title:"TTextEmail",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryBotsInline',
        title:"TTopPeerCategoryBotsInline",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/IContacts',
        title:"IContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelAvailableMessages',
        title:"TUpdateChannelAvailableMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyKeyPhoneCall',
        title:"TPrivacyKeyPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/TPhotos',
        title:"TPhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestPing',
        title:"RequestPing",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputChatPhotoCommon',
        title:"IInputChatPhotoCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockFooter',
        title:"TPageBlockFooter",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputUserCommon',
        title:"IInputUserCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/TCdnFile',
        title:"TCdnFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestRequestCall',
        title:"RequestRequestCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/TPhotosSlice',
        title:"TPhotosSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputStickerSet',
        title:"IInputStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateWebPage',
        title:"TUpdateWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IAuthorization',
        title:"IAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgsAllInfo',
        title:"TMsgsAllInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoto',
        title:"TPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestUploadEncryptedFile',
        title:"RequestUploadEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityBold',
        title:"TMessageEntityBold",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityUnknown',
        title:"TMessageEntityUnknown",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateUserPhone',
        title:"TUpdateUserPhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestDeleteHistory',
        title:"RequestDeleteHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessagesFilterCommon',
        title:"IMessagesFilterCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPopularContact',
        title:"TPopularContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ITopPeerCategory',
        title:"ITopPeerCategory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockVideo',
        title:"TPageBlockVideo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaDocument',
        title:"TMessageMediaDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFilePdf',
        title:"TFilePdf",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ICdnConfig',
        title:"ICdnConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTextUnderline',
        title:"TTextUnderline",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/TPhoneCall',
        title:"TPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebAuthorization',
        title:"TWebAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReadFeaturedStickers',
        title:"RequestReadFeaturedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/TFileCdnRedirect',
        title:"TFileCdnRedirect",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TImportedContacts',
        title:"TImportedContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/INearestDc',
        title:"INearestDc",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TRecentStickers',
        title:"TRecentStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/IPaymentForm',
        title:"IPaymentForm",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IObject',
        title:"IObject",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputChannel',
        title:"TInputChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickerSetItem',
        title:"TInputStickerSetItem",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestUnblock',
        title:"RequestUnblock",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IBotResults',
        title:"IBotResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TClientDHInnerData',
        title:"TClientDHInnerData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyKeyStatusTimestamp',
        title:"TInputPrivacyKeyStatusTimestamp",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRpcError',
        title:"TRpcError",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLangPackString',
        title:"TLangPackString",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatePrivacy',
        title:"TUpdatePrivacy",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallDiscardReasonDisconnect',
        title:"TPhoneCallDiscardReasonDisconnect",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetCdnConfig',
        title:"RequestGetCdnConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedFile',
        title:"TInputEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IEmpty',
        title:"IEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionChangeUsername',
        title:"TChannelAdminLogEventActionChangeUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateConfig',
        title:"TUpdateConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestDeleteChannel',
        title:"RequestDeleteChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPaymentSavedCredentialsCard',
        title:"TPaymentSavedCredentialsCard",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessageReplyTo',
        title:"TInputMessageReplyTo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionTogglePreHistoryHidden',
        title:"TChannelAdminLogEventActionTogglePreHistoryHidden",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TDialogs',
        title:"TDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IDhConfig',
        title:"IDhConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/THttpWait',
        title:"THttpWait",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IShippingOption',
        title:"IShippingOption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeAnimated',
        title:"TDocumentAttributeAnimated",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionToggleSignatures',
        title:"TChannelAdminLogEventActionToggleSignatures",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelAdminRights',
        title:"IChannelAdminRights",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFoundGifs',
        title:"TFoundGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateNewChannelMessage',
        title:"TUpdateNewChannelMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneConnection',
        title:"TPhoneConnection",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionChatEditTitle',
        title:"TMessageActionChatEditTitle",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputGeoPointEmpty',
        title:"TInputGeoPointEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryPeers',
        title:"TTopPeerCategoryPeers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryCorrespondents',
        title:"TTopPeerCategoryCorrespondents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/TRecentMeUrls',
        title:"TRecentMeUrls",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionEmpty',
        title:"TMessageActionEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactLinkUnknown',
        title:"TContactLinkUnknown",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputEncryptedFileUploaded',
        title:"TInputEncryptedFileUploaded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebPagePending',
        title:"TWebPagePending",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IWebPage',
        title:"IWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IRecentStickers',
        title:"IRecentStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateDeleteChannelMessages',
        title:"TUpdateDeleteChannelMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetAllChats',
        title:"RequestGetAllChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TStickerSetInstallResultArchive',
        title:"TStickerSetInstallResultArchive",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRecentMeUrlUser',
        title:"TRecentMeUrlUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestDeleteHistory',
        title:"RequestDeleteHistory",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetFeaturedStickers',
        title:"RequestGetFeaturedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChannelParticipant',
        title:"IChannelParticipant",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateBotCallbackQuery',
        title:"TUpdateBotCallbackQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IDcOption',
        title:"IDcOption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TCodeTypeSms',
        title:"TCodeTypeSms",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/IAdminLogResults',
        title:"IAdminLogResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactStatus',
        title:"TContactStatus",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedChatWaiting',
        title:"TEncryptedChatWaiting",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendMedia',
        title:"RequestSendMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdateUsername',
        title:"RequestUpdateUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateShortSentMessage',
        title:"TUpdateShortSentMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TMessages',
        title:"TMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateServiceNotification',
        title:"TUpdateServiceNotification",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebPage',
        title:"TWebPage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaVenue',
        title:"TMessageMediaVenue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/IImportedContacts',
        title:"IImportedContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Langpack/RequestGetLanguages',
        title:"RequestGetLanguages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateShortMessage',
        title:"TUpdateShortMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoto',
        title:"IPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedChat',
        title:"TEncryptedChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TMessageEditData',
        title:"TMessageEditData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetConfig',
        title:"RequestGetConfig",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadFeaturedStickers',
        title:"TUpdateReadFeaturedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputWebFileLocation',
        title:"TInputWebFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TFutureSalt',
        title:"TFutureSalt",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdatePhoneCall',
        title:"TUpdatePhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileUnknown',
        title:"TFileUnknown",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Langpack/RequestGetStrings',
        title:"RequestGetStrings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageFwdHeader',
        title:"IMessageFwdHeader",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPeerNotifyEvents',
        title:"IPeerNotifyEvents",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputBotInlineMessage',
        title:"IInputBotInlineMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TReplyInlineMarkup',
        title:"TReplyInlineMarkup",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetAdminedPublicChannels',
        title:"RequestGetAdminedPublicChannels",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatParticipantDelete',
        title:"TUpdateChatParticipantDelete",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContactBlocked',
        title:"TContactBlocked",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatAdmins',
        title:"TUpdateChatAdmins",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetChats',
        title:"RequestGetChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatParticipantCreator',
        title:"TChatParticipantCreator",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueDisallowUsers',
        title:"TInputPrivacyValueDisallowUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestSignIn',
        title:"RequestSignIn",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageUploadDocumentAction',
        title:"TSendMessageUploadDocumentAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestReuploadCdnFile',
        title:"RequestReuploadCdnFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateContactRegistered',
        title:"TUpdateContactRegistered",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TSavedGifs',
        title:"TSavedGifs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReorderPinnedDialogs',
        title:"RequestReorderPinnedDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TCodeTypeFlashCall',
        title:"TCodeTypeFlashCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentEmpty',
        title:"TDocumentEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadHistoryOutbox',
        title:"TUpdateReadHistoryOutbox",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessageID',
        title:"TInputMessageID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsBanned',
        title:"TChannelParticipantsBanned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDhGenOk',
        title:"TDhGenOk",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNotifyChats',
        title:"TNotifyChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatPhoto',
        title:"TChatPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestHideReportSpam',
        title:"RequestHideReportSpam",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateNotifySettings',
        title:"TUpdateNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaContact',
        title:"TMessageMediaContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUser',
        title:"IUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickerSetEmpty',
        title:"TInputStickerSetEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestGetFutureSalts',
        title:"RequestGetFutureSalts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelPinnedMessage',
        title:"TUpdateChannelPinnedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageRecordAudioAction',
        title:"TSendMessageRecordAudioAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPhotoEmpty',
        title:"TInputPhotoEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallDiscardReasonMissed',
        title:"TPhoneCallDiscardReasonMissed",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestPingDelayDisconnect',
        title:"RequestPingDelayDisconnect",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedChatEmpty',
        title:"TEncryptedChatEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TMessagesSlice',
        title:"TMessagesSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Upload/RequestGetWebFile',
        title:"RequestGetWebFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetMessageEditData',
        title:"RequestGetMessageEditData",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/SchemaInfo',
        title:"SchemaInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRequest',
        title:"IRequest",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatUserTyping',
        title:"TUpdateChatUserTyping",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendEncryptedFile',
        title:"RequestSendEncryptedFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetMaskStickers',
        title:"RequestGetMaskStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputStickerSetCommon',
        title:"IInputStickerSetCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDestroyAuthKeyNone',
        title:"TDestroyAuthKeyNone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageMediaContact',
        title:"TInputBotInlineMessageMediaContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaVenue',
        title:"TInputMediaVenue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNotifyAll',
        title:"TNotifyAll",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageMediaGame',
        title:"TMessageMediaGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ILangPackString',
        title:"ILangPackString",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputFile',
        title:"IInputFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TStickerSet',
        title:"TStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhoneCallCommon',
        title:"IPhoneCallCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageFwdHeader',
        title:"TMessageFwdHeader",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputChatPhoto',
        title:"TInputChatPhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IUserFull',
        title:"IUserFull",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestDestroyAuthKey',
        title:"RequestDestroyAuthKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/IValidatedRequestedInfo',
        title:"IValidatedRequestedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetStickerSet',
        title:"RequestGetStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityPre',
        title:"TMessageEntityPre",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestValidateRequestedInfo',
        title:"RequestValidateRequestedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TPasswordInputSettings',
        title:"TPasswordInputSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputAppEvent',
        title:"IInputAppEvent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusRecently',
        title:"TUserStatusRecently",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TContacts',
        title:"TContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestUploadMedia',
        title:"RequestUploadMedia",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TAuthorization',
        title:"TAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickerSetID',
        title:"TInputStickerSetID",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChannelMessageViews',
        title:"TUpdateChannelMessageViews",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMsgsAck',
        title:"TMsgsAck",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestGetFullChannel',
        title:"RequestGetFullChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TAuthorization',
        title:"TAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockUnsupported',
        title:"TPageBlockUnsupported",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetPasswordSettings',
        title:"RequestGetPasswordSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRequest_1',
        title:"IRequest<TResult>",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNewSessionCreated',
        title:"TNewSessionCreated",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputStickerSetItem',
        title:"IInputStickerSetItem",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateLangPackTooLong',
        title:"TUpdateLangPackTooLong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputUser',
        title:"IInputUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusOnline',
        title:"TUserStatusOnline",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLangPackDifference',
        title:"TLangPackDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputMediaCommon',
        title:"IInputMediaCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Stickers/RequestRemoveStickerFromSet',
        title:"RequestRemoveStickerFromSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestInviteToChannel',
        title:"RequestInviteToChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaGeoLive',
        title:"TInputMediaGeoLive",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IExportedMessageLink',
        title:"IExportedMessageLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageUploadAudioAction',
        title:"TSendMessageUploadAudioAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNearestDc',
        title:"TNearestDc",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdateProfile',
        title:"RequestUpdateProfile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetTermsOfService',
        title:"RequestGetTermsOfService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/TPrivacyRules',
        title:"TPrivacyRules",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputFile',
        title:"TInputFile",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReportEncryptedSpam',
        title:"RequestReportEncryptedSpam",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockAudio',
        title:"TPageBlockAudio",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantSelf',
        title:"TChannelParticipantSelf",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TEncryptedChatDiscarded',
        title:"TEncryptedChatDiscarded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputChannelEmpty',
        title:"TInputChannelEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateContactsReset',
        title:"TUpdateContactsReset",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueDisallowContacts',
        title:"TInputPrivacyValueDisallowContacts",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputChatPhotoEmpty',
        title:"TInputChatPhotoEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestCheckUsername',
        title:"RequestCheckUsername",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallWaiting',
        title:"TPhoneCallWaiting",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/ICodeType',
        title:"ICodeType",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TAllStickersNotModified',
        title:"TAllStickersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestExportCard',
        title:"RequestExportCard",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateDeleteMessages',
        title:"TUpdateDeleteMessages",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhotoCachedSize',
        title:"TPhotoCachedSize",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDhGenFail',
        title:"TDhGenFail",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateReadHistoryInbox',
        title:"TUpdateReadHistoryInbox",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Bots/RequestAnswerWebhookJSONQuery',
        title:"RequestAnswerWebhookJSONQuery",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TReceivedNotifyMessage',
        title:"TReceivedNotifyMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ICdnPublicKey',
        title:"ICdnPublicKey",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/IInviteText',
        title:"IInviteText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/IPasswordSettings',
        title:"IPasswordSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestUpdatePinnedMessage',
        title:"RequestUpdatePinnedMessage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/ITopPeerCategoryPeers',
        title:"ITopPeerCategoryPeers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionCustomAction',
        title:"TMessageActionCustomAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRichTextCommon',
        title:"IRichTextCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMediaDocument',
        title:"TInputMediaDocument",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannel',
        title:"TChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TLangPackLanguage',
        title:"TLangPackLanguage",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInvoice',
        title:"TInvoice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TNotifyUsers',
        title:"TNotifyUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TDialogsSlice',
        title:"TDialogsSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetEncryptedTyping',
        title:"RequestSetEncryptedTyping",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageActionPaymentSentMe',
        title:"TMessageActionPaymentSentMe",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSearch',
        title:"RequestSearch",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputStickerSetShortName',
        title:"TInputStickerSetShortName",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateLangPack',
        title:"TUpdateLangPack",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/IHighScores',
        title:"IHighScores",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IFileHash',
        title:"IFileHash",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestSendPaymentForm',
        title:"RequestSendPaymentForm",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/RequestGetSavedInfo',
        title:"RequestGetSavedInfo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestCreateChannel',
        title:"RequestCreateChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockEmbedPost',
        title:"TPageBlockEmbedPost",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonUrl',
        title:"TKeyboardButtonUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetAllStickers',
        title:"RequestGetAllStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/IRecentMeUrls',
        title:"IRecentMeUrls",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPeerNotifyEventsEmpty',
        title:"TInputPeerNotifyEventsEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestRpcDropAnswer',
        title:"RequestRpcDropAnswer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateEncryption',
        title:"TUpdateEncryption",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageMediaCommon',
        title:"IMessageMediaCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestTogglePreHistoryHidden',
        title:"RequestTogglePreHistoryHidden",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonRow',
        title:"TKeyboardButtonRow",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/RequestLogOut',
        title:"RequestLogOut",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TChannelDifferenceEmpty',
        title:"TChannelDifferenceEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TKeyboardButtonGame',
        title:"TKeyboardButtonGame",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPrivacyValueDisallowUsers',
        title:"TPrivacyValueDisallowUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TPaymentForm',
        title:"TPaymentForm",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatInviteEmpty',
        title:"TChatInviteEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputFileLocation',
        title:"TInputFileLocation",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TImportedContact',
        title:"TImportedContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageGamePlayAction',
        title:"TSendMessageGamePlayAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityHashtag',
        title:"TMessageEntityHashtag",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Photos/RequestUpdateProfilePhoto',
        title:"RequestUpdateProfilePhoto",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IResPQ',
        title:"IResPQ",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IBotCommand',
        title:"IBotCommand",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Users/RequestGetFullUser',
        title:"RequestGetFullUser",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestSetStickers',
        title:"RequestSetStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendEncrypted',
        title:"RequestSendEncrypted",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IStickerPack',
        title:"IStickerPack",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputPaymentCredentials',
        title:"IInputPaymentCredentials",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TReplyKeyboardForceReply',
        title:"TReplyKeyboardForceReply",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TContact',
        title:"TContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockDivider',
        title:"TPageBlockDivider",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/RequestGetChannelDifference',
        title:"RequestGetChannelDifference",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestSearch',
        title:"RequestSearch",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TExportedMessageLink',
        title:"TExportedMessageLink",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputBotInlineMessageText',
        title:"TInputBotInlineMessageText",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetAttachedStickers',
        title:"RequestGetAttachedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetInlineBotResults',
        title:"RequestSetInlineBotResults",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TSentCodeTypeCall',
        title:"TSentCodeTypeCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TTopPeersNotModified',
        title:"TTopPeersNotModified",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TPeerDialogs',
        title:"TPeerDialogs",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFileJpeg',
        title:"TFileJpeg",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMaskCoords',
        title:"TMaskCoords",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/TDifferenceTooLong',
        title:"TDifferenceTooLong",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTrue',
        title:"TTrue",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagePinned',
        title:"TInputMessagePinned",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Updates/IDifferenceCommon',
        title:"IDifferenceCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageRecordRoundAction',
        title:"TSendMessageRecordRoundAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IEncryptedChat',
        title:"IEncryptedChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPageBlockPreformatted',
        title:"TPageBlockPreformatted",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Phone/RequestSaveCallDebug',
        title:"RequestSaveCallDebug",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/ITopPeers',
        title:"ITopPeers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelAdminLogEventActionParticipantJoin',
        title:"TChannelAdminLogEventActionParticipantJoin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestUpdateNotifySettings',
        title:"RequestUpdateNotifySettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/IExportedAuthorization',
        title:"IExportedAuthorization",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestGetWallPapers',
        title:"RequestGetWallPapers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/TBlockedSlice',
        title:"TBlockedSlice",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IImportedContact',
        title:"IImportedContact",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterRoundVideo',
        title:"TInputMessagesFilterRoundVideo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputMessagesFilterPhotos',
        title:"TInputMessagesFilterPhotos",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IInputBotInlineResult',
        title:"IInputBotInlineResult",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IPhotoSizeCommon',
        title:"IPhotoSizeCommon",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChannelParticipantsRecent',
        title:"TChannelParticipantsRecent",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TWebPageEmpty',
        title:"TWebPageEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Help/RequestGetAppUpdate',
        title:"RequestGetAppUpdate",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TStickerSet',
        title:"TStickerSet",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TDocumentAttributeVideo',
        title:"TDocumentAttributeVideo",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendEncryptedService',
        title:"RequestSendEncryptedService",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPaymentCredentialsAndroidPay',
        title:"TInputPaymentCredentialsAndroidPay",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IChat',
        title:"IChat",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestSendChangePhoneCode',
        title:"RequestSendChangePhoneCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSearchGlobal',
        title:"RequestSearchGlobal",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Account/RequestChangePhone',
        title:"RequestChangePhone",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestInvokeWithoutUpdates',
        title:"RequestInvokeWithoutUpdates",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TInputPrivacyValueAllowUsers',
        title:"TInputPrivacyValueAllowUsers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUpdateChatParticipantAdmin',
        title:"TUpdateChatParticipantAdmin",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TMessageEntityCode',
        title:"TMessageEntityCode",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Auth/TSentCodeTypeApp',
        title:"TSentCodeTypeApp",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCall',
        title:"TPhoneCall",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatParticipantsForbidden',
        title:"TChatParticipantsForbidden",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TSendMessageGeoLocationAction',
        title:"TSendMessageGeoLocationAction",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhoneCallDiscarded',
        title:"TPhoneCallDiscarded",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/TFoundStickerSets',
        title:"TFoundStickerSets",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TTopPeerCategoryGroups',
        title:"TTopPeerCategoryGroups",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSetGameScore',
        title:"RequestSetGameScore",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IRecentMeUrl',
        title:"IRecentMeUrl",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Channels/RequestLeaveChannel',
        title:"RequestLeaveChannel",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRecentMeUrlChatInvite',
        title:"TRecentMeUrlChatInvite",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Storage/TFilePng',
        title:"TFilePng",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPagePart',
        title:"TPagePart",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TUserStatusEmpty',
        title:"TUserStatusEmpty",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestGetTopPeers',
        title:"RequestGetTopPeers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Contacts/RequestResetTopPeerRating',
        title:"RequestResetTopPeerRating",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TRpcAnswerDroppedRunning',
        title:"TRpcAnswerDroppedRunning",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestInvokeAfterMsg',
        title:"RequestInvokeAfterMsg",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestSendScreenshotNotification',
        title:"RequestSendScreenshotNotification",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetPeerSettings',
        title:"RequestGetPeerSettings",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetCommonChats',
        title:"RequestGetCommonChats",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Payments/TPaymentReceipt',
        title:"TPaymentReceipt",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageEntity',
        title:"IMessageEntity",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TChatForbidden',
        title:"TChatForbidden",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/IMessageRange',
        title:"IMessageRange",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestReport',
        title:"RequestReport",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema.Messages/RequestGetFavedStickers',
        title:"RequestGetFavedStickers",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/RequestInvokeWithLayer',
        title:"RequestInvokeWithLayer",
        description:""
    });

    y({
        url:'/OpenTl.Schema/api/OpenTl.Schema/TPhotoSizeEmpty',
        title:"TPhotoSizeEmpty",
        description:""
    });

    return {
        search: function(q) {
            return idx.search(q).map(function(i) {
                return idMap[i.ref];
            });
        }
    };
}();
