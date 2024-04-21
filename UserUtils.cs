using System;

namespace Aquarium
{
    static class UserUtils
    {
        private static Random s_random;

        static public int GetRandomNumber()
        {
            int minValue = 10;
            int maxValue = 20;

            s_random = new Random();

            return s_random.Next(minValue,maxValue);
        }
    }
}