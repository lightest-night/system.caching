using System;
using Shouldly;
using Xunit;

namespace LightestNight.System.Caching.Tests
{
    public class CacheItemFactoryTests
    {
        private readonly ICacheItemFactory _sut = new CacheItemFactory();

        [Fact]
        public void Should_Create_New_Item()
        {
            // Arrange
            const string key = "TEST_KEY";
            var tags = new[] {"tag1", "tag2"};
            
            // Act
            var result = _sut.Create(key, tags);
            
            // Assert
            result.Key.ShouldBe(key);
            result.Tags.ShouldBe(tags);
        }

        [Fact]
        public void Should_Create_New_Item_With_Value()
        {
            // Arrange
            const string key = "TEST_KEY";
            var tags = new[] {"tag1", "tag2"};
            var expiry = DateTime.Now.AddMinutes(10);
            var value = new {Value = "Value"};
            
            // Act
            var result = _sut.Create(key, value, expiry, tags);
            
            // Assert
            result.Key.ShouldBe(key);
            result.Tags.ShouldBe(tags);
            result.Value.ShouldBe(value);
            result.Expiry.ShouldBe(expiry);
        }
    }
}