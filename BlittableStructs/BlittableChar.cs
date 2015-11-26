using System.Runtime.InteropServices;

namespace BlittableStructs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct BlittableChar
    {
        public char Value;

        public BlittableChar(char value)
        {
            Value = value;
        }

        public static explicit operator BlittableChar(char value)
        {
            return new BlittableChar { Value = value };
        }

        public static implicit operator char (BlittableChar value)
        {
            return value.Value;
        }
    }
}