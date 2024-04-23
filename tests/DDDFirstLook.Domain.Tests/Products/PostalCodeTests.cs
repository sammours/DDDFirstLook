using DDDFirstLook.Domain.Primitives;
using System;
using Xunit;

namespace DDDFirstLook.Domain.Tests.Primitives
{
    public class PostalCodeTests
    {
        [Fact]
        public void PostalCode_IsValidTest()
        {
            var result1 = PostalCode.IsValid(null);
            var result2 = PostalCode.IsValid("12345");
            var result3 = PostalCode.IsValid("ddddd");
            var result4 = PostalCode.IsValid("d123d");
            var result5 = PostalCode.IsValid("dddddghhj");

            Assert.False(result1);
            Assert.True(result2);
            Assert.False(result3);
            Assert.False(result4);
            Assert.False(result5);
        }
    }
}
