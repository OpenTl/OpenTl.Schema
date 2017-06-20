namespace OpenTl.Schema.Contest
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a5f6e95)]
    public class RequestSaveDeveloperInfo : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int VkId {get; set;}

       [SerializationOrder(1)]
       public string Name {get; set;}

       [SerializationOrder(2)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(3)]
       public int Age {get; set;}

       [SerializationOrder(4)]
       public string City {get; set;}

    }
}
