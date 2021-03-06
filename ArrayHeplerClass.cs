using System;
namespace ArrayHelper
{
    static class ArrayHelper<T>
    {
        public static T Pop(ref T[] array)
        {
            int n  = array.Length;
            T deleted_element = array[n-1];
            T[] array_helper = new T[n-1];
            

            for (int i = 0; i < n-1; i++)
            {
                array_helper[i] = array[i];
            }
            array = array_helper;

            return deleted_element;
        }
        public static int Push(ref T[] array, T new_element)
        {
            int n  = array.Length;
            T[] array_helper = new T[n+1];


            for (int i = 0; i < n+1; i++)
            {
                array_helper[i] = (i == n) ? new_element : array[i];
            }
            array = array_helper;

            return array.Length;
        }
        public static T Shift(ref T[] array)
        {
            int n  = array.Length;
            T deleted_element = array[0];
            T[] array_helper = new T[n-1];


            for (int i = 1; i < n; i++)
            {
                array_helper[i-1] = array[i];
            }
            array = array_helper;

            return deleted_element;
        }
        public static int UnShift(ref T[] array, T new_element)
        {
            int n  = array.Length;
            T[] array_helper = new T[n+1];

            for (int i = 0; i < n+1; i++)
            {
                array_helper[i] = (i == 0) ? new_element : array[i-1];
            }
            array = array_helper;

            return array.Length;
        }
        public static T[] Slice(ref T[] array, int? begin_index = null, int? end_index = null)
        {
            int len = array.Length;
            begin_index = begin_index ?? 0;
            end_index   = end_index   ?? len;
            
            if (end_index < 0)
            {
                end_index = len  + end_index;
            }
            if (begin_index < 0)
            {
                begin_index = end_index + begin_index;
            }

            int new_len = (end_index - begin_index > 0) ? (int)(end_index - begin_index):0; 
            Console.WriteLine($"new len = {new_len}");
            T[] sub_array = new T[new_len];
            for (int i = 0; i < new_len; i++)
            {
                sub_array[i] = array[i + (int)begin_index];
            }
            return sub_array;        
        }
    }
}