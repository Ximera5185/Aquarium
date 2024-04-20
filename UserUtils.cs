using System;

namespace Aquarium
{
    static class UserUtils
    {
        private static Random s_random;

        static public int GetRandomNumber()
        {
            int minValue = 1;
            int maxValue = 10;

            s_random = new Random();

            return s_random.Next(minValue,maxValue);
        }
    }
}