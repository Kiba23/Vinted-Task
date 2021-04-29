using System;

namespace DiscountEvaluator.Helpers
{
    public static class TryParser
    {
        public static Sizes SizeTryParse(string value)
        {
            if (Enum.TryParse(value, out Sizes result))
            {
                return result;
            }
            throw new InvalidCastException("Wrong cast");
        }

        public static Companies CompanyTryParse(string value)
        {
            if (Enum.TryParse(value, out Companies result))
            {
                return result;
            }
            throw new InvalidCastException("Wrong cast");
        }
    }
}
