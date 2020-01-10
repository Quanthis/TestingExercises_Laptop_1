using System;

namespace CzynnikiPierwsze
{
    public class LiczbyPierwsze
    {
        public int ZnajdzLiczbePierwsza(int a)
        {
            for (int i=1; i<=a/2; i++)
            {
                if (a % i == 0)
                {
                    return 0;
                }
                else
                {
                    return i;
                }
            }
        }
    }
}
