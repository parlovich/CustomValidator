using NUnit.Framework;
using System;
namespace CustomValidator
{
    [TestFixture]
    public class IdentityValidatorTests
    {
        [Test]
        public void ValidateTestCase()
        {
            var validator = new IdentityValidator();
            var expected = true;
            var actual = validator.Validate("fakedata");
            Assert.AreEqual(expected, actual);
        }
    }
}
