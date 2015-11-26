using System;
using Xunit;

namespace BlittableStructs.Tests
{
    public class ConstructorTests
    {
        [Fact]
        public void BooleanTest()
        {
            const bool value = true;
            var blittable = new BlittableBoolean(value);
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void CharTest()
        {
            const char value = 'x';
            var blittable = new BlittableChar(value);
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void DateTimeTest()
        {
            var value = new DateTime(2015, 1, 1);
            var blittable = new BlittableDateTime(value);
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void DecimalTest()
        {
            var value = new decimal(1.234);
            var blittable = new BlittableDecimal(value);
            Assert.Equal(value, blittable);
        }
    }
}