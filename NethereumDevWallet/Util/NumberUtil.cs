using System;

namespace NethereumDevWallet.Util
{
    public static class NumberUtil
    {
        public static int GetDecimalPlaces(decimal number)
        {
            if (number == 0)
                return 0;

            var i = 1;
            while (Decimal.Round(number, i) != number)
                i++;

            return i;
        }
    }
}
