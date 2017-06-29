// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorization : IObject
    {
        long Hash {get; set;}

        int Flags {get; set;}

        string DeviceModel {get; set;}

        string Platform {get; set;}

        string SystemVersion {get; set;}

        int ApiId {get; set;}

        string AppName {get; set;}

        string AppVersion {get; set;}

        int DateCreated {get; set;}

        int DateActive {get; set;}

        string Ip {get; set;}

        string Country {get; set;}

        string Region {get; set;}

    }
}
