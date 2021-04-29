using System;

namespace DiscountEvaluator.Helpers
{
    public static class TryParser
    {
        public static DateTime DateTimeTryParse(string value)
        {
            if (DateTime.TryParse(value, out DateTime result))
            {
                return result;
            }
            throw new InvalidCastException("Wrong cast.");
        }

        public static Sizes SizeTryParse(string value)
        {
            if (Enum.TryParse(value, out Sizes result))
            {
                return result;
            }
            throw new InvalidCastException("Wrong cast.");
        }

        public static Companies CompanyTryParse(string value)
        {
            if (Enum.TryParse(value, out Companies result))
            {
                return result;
            }
            throw new InvalidCastException("Wrong cast.");
        }
    }
}
