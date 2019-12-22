using System;

namespace ExtensionMethods
{
    internal static class StringExtensions
    {
        internal static string UppercaseFirstLetter(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }

            return value;
        }

        internal static string LowercaseFirstLetter(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToLower(array[0]);
                return new string(array);
            }

            return value;
        }

        internal static string Null(this string value)
        {
            return value;
        }
    }
}
