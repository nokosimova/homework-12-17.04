using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[] {'a', 'b', 'c', 'd','e', 'f', 'g', 'h', 'j', 'k'};
            Console.WriteLine(@"Выберите команду:
Pop------1
Push-----2
Shift----3
Unshift--4
Slice----5
Exit-----6");
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
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
                    case 6:
                    break;
                    default:
                    break;
                }
            }


        }
    }
}
