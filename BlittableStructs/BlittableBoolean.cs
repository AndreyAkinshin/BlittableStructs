using System;

namespace BlittableStructs
{
    public struct BlittableBoolean
    {
        private byte byteValue;

        public BlittableBoolean(bool value)
        {
            byteValue = Convert.ToByte(value);
        }

        public bool Value
        {
            get { return Convert.ToBoolean(byteValue); }
            set { byteValue = Convert.ToByte(value); }
        }

        public static explicit operator BlittableBoolean(bool value)
        {
            return new BlittableBoolean { Value = value };
        }

        public static implicit operator bool (BlittableBoolean value)
        {
            return value.Value;
        }
    }
}