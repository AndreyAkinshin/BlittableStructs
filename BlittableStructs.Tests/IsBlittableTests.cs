using System;
using Xunit;

namespace BlittableStructs.Tests
{
    public class IsBlittableTests
    {
        private struct BlittableBooleanWrapper
        {
            public BlittableBoolean Value;
        }

        private struct BlittableCharWrapper
        {
            public BlittableChar Value;
        }

        private struct BlittableDateTimeWrapper
        {
            public BlittableDateTime Value;
        }

        private struct BlittableDecimalWrapper
        {
            public BlittableDecimal Value;
        }

        private struct BlittableCompositeWrapper
        {
            public BlittableBoolean Boolean;
            public BlittableChar Char;
            public BlittableDateTime DateTime;
            public BlittableDecimal Decimal;
        }

        private struct DecimalWrapper
        {
            public decimal Value;
        }

        [Fact]
        public void BooleanTest()
        {
            Assert.False(BlittableHelper.IsBlittable<bool>());
        }

        [Fact]
        public void CharTest()
        {
            Assert.False(BlittableHelper.IsBlittable<char>());
        }

        [Fact]
        public void DateTimeTest()
        {
            Assert.False(BlittableHelper.IsBlittable<DateTime>());
        }

        [Fact]
        public void DecimalTest()
        {
            Assert.False(BlittableHelper.IsBlittable<decimal>());
        }

        [Fact]
        public void DecimalWrapperTest()
        {
            Assert.False(BlittableHelper.IsBlittable<DecimalWrapper>());
        }

        [Fact]
        public void BlittableBooleanTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableBoolean>());
        }

        [Fact]
        public void BlittableCharTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableChar>());
        }

        [Fact]
        public void BlittableDateTimeTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableDateTime>());
        }

        [Fact]
        public void BlittableDecimalTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableDecimal>());
        }

        [Fact]
        public void BlittableBooleanWrapperTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableBooleanWrapper>());
        }

        [Fact]
        public void BlittableCharWrapperTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableCharWrapper>());
        }

        [Fact]
        public void BlittableDateTimeWrapperTest()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableDateTimeWrapper>());
        }

        [Fact]
        public void BlittableDecimalTestWrapper()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableDecimalWrapper>());
        }

        [Fact]
        public void BlittableCompositeTestWrapper()
        {
            Assert.True(BlittableHelper.IsBlittable<BlittableCompositeWrapper>());
        }

        [Fact]
        public void ArrayTest()
        {
            Assert.True(BlittableHelper.IsBlittable<int[]>());
        }
    }
}