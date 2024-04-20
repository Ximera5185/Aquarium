using System;

namespace Aquarium
{
    static class UserUtils
    {
        private static Random s_random = new Random();

        static public int GetRandomNumber(int minValue, int maxValue)
        {
            return s_random.Next(minValue,maxValue);
        }
    }
}