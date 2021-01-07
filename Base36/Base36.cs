using System;
using System.Text;

namespace Base36
{
    /// <summary>
    /// Handles encoding and decoding of Base36 strings
    /// </summary>
    public static class Base36
    {
        /// <summary>
        /// The conversion base, 36 in this case, of course
        /// </summary>
        private const int Radix = 36;
        
        /// <summary>
        /// The complete set of 36 characters, in order
        /// </summary>
        private const string Charset = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        /// <summary>
        /// Encode an `ulong` to a Base36 string
        /// </summary>
        /// <param name="input">The number to encode</param>
        /// <returns>The encoded string</returns>
        public static string Encode(ulong input)
        {
            var charset = Charset.AsSpan();
            var sb = new StringBuilder();
            
            while (input > 0)
            {
                sb.Insert(0, charset[(int) (input % Radix)]);
                input /= Radix;
            }

            return sb.ToString();
        }
        
        /// <summary>
        /// Encode an `ulong` to a Base36 string
        /// </summary>
        /// <param name="input">The number to encode</param>
        /// <returns>The encoded string</returns>
        public static string ToBase36(this ulong input) => Encode(input);

        
        /// <summary>
        /// Decode a Base36 string to an `ulong`
        /// </summary>
        /// <param name="input">The string to decode</param>
        /// <returns>The decoded number</returns>
        public static ulong Decode(string input)
        {
            var charset = Charset.AsSpan();
            var chars = input.ToUpper().AsSpan();
            var len = chars.Length;

            ulong result = 0;
            var iter = 0;
            
            for (var i = len - 1; i >= 0; i--)
            {
                result += (ulong)charset.IndexOf(chars[i]) * (ulong)Math.Pow(Radix, iter++);
            }

            return result;
        }
        
        /// <summary>
        /// Decode a Base36 string to an `ulong`
        /// </summary>
        /// <param name="input">The string to decode</param>
        /// <returns>The decoded number</returns>
        public static ulong FromBase36(this string input) => Decode(input);
    }
}