using System;

namespace BlittableStructs
{
    public struct BlittableDateTime
    {
        private long ticks;

        public BlittableDateTime(DateTime dateTime)
        {
            ticks = dateTime.Ticks;
        }

        public DateTime Value
        {
            get { return new DateTime(ticks); }
            set { ticks = value.Ticks; }
        }

        public static explicit operator BlittableDateTime(DateTime value)
        {
            return new BlittableDateTime { Value = value };
        }

        public static implicit operator DateTime(BlittableDateTime value)
        {
            return value.Value;
        }
    }
}