/// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
/// Заполнить случайными числами. 
/// Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
/// В данной задаче под парой подразумевается два подряд идущих элемента массива.
/// Andrey Kovalenko

using System;


namespace AmountOfPairsInArray
{
    class Program
    {
        /// <summary>Метод подсчёта количества пар элементов массива, в которых хотя бы одно число делится на 3</summary>
        /// <param name="array">Массив элементов</param>
        /// <param name="length">Длинна массива элементов</param>
        /// <returns></returns>
        static int GetNumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length-1; i++)
            {
                if (array[i] % 3 == 0 || array[i+1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random random = new Random();
            int result;

            Console.WriteLine("Вас приветствует программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
            Console.Write("\nВ следующем массиве [ ");
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(-10000, 10001);
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");

            result = GetNumberOfPairs(myArray, arrayLength);

            Console.WriteLine($"Количество пар: {result}");

            Console.ReadKey();
        }
    }
}
