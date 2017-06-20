using System;
using System.Reflection;
using OpenTl.Schema.Serialization;
using Xunit;

namespace OpenTl.Schema.Tests
{
    public class SerializeTests
    {
        [Fact]
        public void Test1()
        {
            var message = new TMessage();

            var data = Serializer.SerializeObject(message);
            
        }
    }
}