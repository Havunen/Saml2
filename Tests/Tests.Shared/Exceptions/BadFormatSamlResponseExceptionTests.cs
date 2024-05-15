using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Sustainsys.Saml2.Exceptions;

namespace Sustainsys.Saml2.Tests.Exceptions
{
    [TestClass]
    public class BadFormatSamlResponseExceptionTests
    {
        [TestMethod]
        public void BadFormatSamlResponseException_DefaultCtor()
        {
            ExceptionTestHelpers.TestDefaultCtor<BadFormatSamlResponseException>();
        }

        // JNi 2024-04-15: Binary Serialization and classes used in the mentioned
        // serialization constructor are obsolete in NET 8 -> Do not do this.
        [Ignore]
        [TestMethod]
        public void BadFormatSamlResponseException_SerializationCtor()
        {
            ExceptionTestHelpers.TestSerializationCtor<BadFormatSamlResponseException>();
        }

        [TestMethod]
        public void BadFormatSamlResponseException_StringCtor()
        {
            var msg = "Message!";
            var subject = new BadFormatSamlResponseException(msg);

            subject.Message.Should().Be(msg);
        }
    }
}
