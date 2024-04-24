using System;

namespace Aquarium
{
    static class UserUtils
    {
         static UserUtils() 
        {
            Random s_random = new Random();
        }
    

        static public int GetRandomNumber(int minValue,int maxValue)
        {
           // s_random = new Random();

            return s_random.Next(minValue,maxValue);
        }
    }
}