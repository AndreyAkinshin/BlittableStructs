using System;
using Xunit;

namespace BlittableStructs.Tests
{
    public class ConvertionTests
    {
        [Fact]
        public void BooleanTest()
        {
            const bool value = true;
            BlittableBoolean blittable = (BlittableBoolean) value;
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void CharTest()
        {
            const char value = 'x';
            BlittableChar blittable = (BlittableChar) value;
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void DateTimeTest()
        {
            var value = new DateTime(2015, 1, 1);
            BlittableDateTime blittable = (BlittableDateTime) value;
            Assert.Equal(value, blittable);
        }

        [Fact]
        public void DecimalTest()
        {
            var value = new decimal(1.234);
            BlittableDecimal blittable = (BlittableDecimal) value;
            Assert.Equal(value, blittable);
        }
    }
}