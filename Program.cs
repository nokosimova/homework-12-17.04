using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
            Console.WriteLine("Исходный массив");
            for(int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
            Console.Write("\n");
            Console.WriteLine(@"Выберите команду:
Pop------1   Push-----2
Shift----3   Unshift--4
Slice----5   Exit-----6");
            int c = int.Parse(Console.ReadLine());
            while (c != 6)
            {
                switch(c)
                {
                    case 1:
                        Console.WriteLine($"Удаленный элемент: {ArrayHelper<char>.Pop(ref array)}");
                        Console.WriteLine("Изменённый массив:");
                        for(int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 2:
                        Console.Write("добавляемый элемент = ");
                        char adding_element = char.Parse(Console.ReadLine());
                        
                        ArrayHelper<char>.Push(ref array, adding_element);
                        Console.WriteLine("Изменённый массив:");
                        for(int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Удаленный элемент: {ArrayHelper<char>.Shift(ref array)}");
                        Console.WriteLine("Изменённый массив:");
                        for(int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 4:
                        Console.Write("добавляемый элемент = ");
                        adding_element = char.Parse(Console.ReadLine());
                        
                        ArrayHelper<char>.UnShift(ref array, adding_element);
                        Console.WriteLine("Изменённый массив:");
                        for(int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 5:
                        int? begin = null, end = null;
                        Console.WriteLine("начальный индекс: указать-0  | не указывать-1");
                        int cc = int.Parse(Console.ReadLine());
                        if (cc == 0)
                        {
                            Console.Write("begin_index = ");
                            begin = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("конечный индекс: указать-0  | не указывать-1");
                        cc = int.Parse(Console.ReadLine());
                        if (cc == 0)
                        {
                            Console.Write("end_index = ");
                            end = int.Parse(Console.ReadLine());
                        }
                        char[] new_array = ArrayHelper<char>.Slice(ref array,begin,end);
                        Console.WriteLine("Подмассив:");
                        for(int i = 0; i < new_array.Length; i++)
                        {
                            Console.Write($"{new_array[i]} ");
                        }
                        break;
                    case 6:
                    break;
                    default:
                    break;
                }
                if (c != 6)
                {
                    Console.Write("\n");
                    Console.WriteLine(@"Выберите команду:
Pop------1   Push-----2
Shift----3   Unshift--4
Slice----5   Exit-----6");
                    c = int.Parse(Console.ReadLine());
                }
                
            }


        }
    }
}
