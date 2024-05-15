using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Sustainsys.Saml2.Exceptions;

namespace Sustainsys.Saml2.Tests.Exceptions
{
    [TestClass]
    public class InvalidSignatureExceptionTests
    {
        [TestMethod]
        public void InvalidSignatureException_DefaultCtor()
        {
            ExceptionTestHelpers.TestDefaultCtor<InvalidSignatureException>();
        }

        // JNi 2024-04-15: Binary Serialization and classes used in the mentioned
        // serialization constructor are obsolete in NET 8 -> Do not do this.
        [Ignore]
        [TestMethod]
        public void InvalidSignatureException_SerializationCtor()
        {
            ExceptionTestHelpers.TestSerializationCtor<InvalidSignatureException>();
        }

        [TestMethod]
        public void InvalidSignatureException_StringCtor()
        {
            var msg = "Message!";
            var subject = new InvalidSignatureException(msg);

            subject.Message.Should().Be(msg);
        }

        [TestMethod]
        public void InvalidSignatureException_InnerExceptionCtor()
        {
            var inner = new Exception("inner");
            var msg = "Message!";

            var subject = new InvalidSignatureException(msg, inner);

            subject.Message.Should().Be(msg);
            subject.InnerException.Should().Be(inner);
        }
    }
}
