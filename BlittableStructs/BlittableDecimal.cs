namespace BlittableStructs
{
    public struct BlittableDecimal
    {
        private long longValue;

        public BlittableDecimal(decimal value)
        {
            longValue = decimal.ToOACurrency(value);
        }

        public decimal Value
        {
            get { return decimal.FromOACurrency(longValue); }
            set { longValue = decimal.ToOACurrency(value); }
        }

        public static explicit operator BlittableDecimal(decimal value)
        {
            return new BlittableDecimal { Value = value };
        }

        public static implicit operator decimal (BlittableDecimal value)
        {
            return value.Value;
        }
    }
}