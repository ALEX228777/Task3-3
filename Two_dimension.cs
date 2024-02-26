using System;
namespace Task3_1
{
	public class Two_dimension : ArraysParent, IFlip, IPrint
	{
        private int[,] array;
        public Two_dimension(bool randi) : base(randi)
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
            Console.WriteLine("Количество столбцов");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество строк");
            int rows = int.Parse(Console.ReadLine());
            array = new int[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        protected override void Fill_array_random()
        {
            Random random1 = new Random();
            int rows = random1.Next(3, 10);
            int columns = rows;
            array = new int[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random1.Next(-250, 250);
                }
            }
            Console.WriteLine();
        }

        public override void Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            decimal result = sum / (array.GetLength(0) * array.GetLength(1));
            Console.WriteLine("Среднее значение массива:");
            Console.WriteLine(result);
            Console.WriteLine();
        }
        void IFlip.Flip(){
            Console.WriteLine("Массив с перевернутыми строками:");
            for (int i = 0; i < array.GetLength(0); i++){
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1); j > 0; j--)
                    {
                        Console.Write(array[i, j-1] + " ");
                    }
                }
                else
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                         Console.Write(array[i, k] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        void IPrint.Print(){
            Console.WriteLine("Двумерный массив");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
   
            Console.WriteLine();
        }
        public override void Print()
        {
            Console.WriteLine("Двумерный массив");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
  

   
            Console.WriteLine();
        }

    }
}

