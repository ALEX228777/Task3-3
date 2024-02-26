using System;
namespace Task3_1
{
	public class Jagged : ArraysParent, IPrint
	{
        private int[][] array;

        public Jagged( bool randi) : base(randi)
        {
            if (randi)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }
        }

        public override void Createarray(bool randi)
        {

            if (randi)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }
        }
        protected override void Fill_array()
        {
            Console.WriteLine("Введите количество массивов");
            int n = int.Parse(Console.ReadLine());
            array = new int[n][];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                Console.WriteLine();

                array[i] = new int[Length];

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"Введите элемент массива {i}:");

                    int l = int.Parse(Console.ReadLine());

                    array[i][j] = l;

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        protected override void Fill_array_random()
        {
            Random random3 = new Random();
            array = new int[random3.Next(3, 10)][];
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                array[i] = new int[Length];

                for (int j = 0; j < array[i].Length; j++)
                {
                    int l = random3.Next(-250, 250);

                    array[i][j] = l;
                }
                Console.WriteLine();
            }
        }
        public override void Getmiddle()
        {
            Console.WriteLine();
            decimal sum = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int len = array[i].Length;
                int suma = array[i].Sum();
                Console.WriteLine($"Среднее значение массива {i}:");
                Console.WriteLine(suma / len);
                Console.WriteLine();
                counter += array[i].Length;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }
            decimal result = sum / counter;
            Console.WriteLine("Среднее значение массива:");
            Console.WriteLine(result);
            Console.WriteLine();
        }
        void IPrint.Print(){
            Console.WriteLine("Зубчатый массив");
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.Write($"{array[i][l]} \t");
                }
                Console.WriteLine();
            }
        }
        public override void Print()
        {
            Console.WriteLine("Зубчатый массив");
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.Write($"{array[i][l]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}

