// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMsgDetailedInfo : IObject
    {
       long AnswerMsgId {get; set;}

       int Bytes {get; set;}

       int Status {get; set;}

    }
}
