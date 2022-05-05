using System;
namespace cab
{
    public class Calaculate
    {
        public static int value(string location)
        {
            int a = 0;
            a = location.Length;
            int count = 0;
            for (int i = 0; i < count; i++)
            {
                if (location[i] == 'a' || location[i] == 'e' || location[i] == 'i' || location[i] == 'o' || location[i] == 'u')
                    count++;
            }
            a = a +(a* count);
            return a;
        }
    }
}

