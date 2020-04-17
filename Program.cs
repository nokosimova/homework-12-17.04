using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,6};
            int[] b = ArrayHelper<int>.Slice(ref a,2);
            for (int i = 0; i < b.Length; i++)
                Console.Write($"{b[i]} ");
        }


    }
}
