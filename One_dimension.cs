using System;
namespace Task3_1
{
	public class One_dimension : ArraysParent, IRemove, IPrint
	{
        private int[] array;
        public One_dimension(bool randi) : base(randi)
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
            Console.WriteLine();


            int length = int.Parse(Console.ReadLine());
            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        protected override void Fill_array_random()
        {
            Random random = new Random();
            array = new int[random.Next(3, 10)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();
        }

        public override void Getmiddle()
        {
            decimal suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            decimal result = suma / array.Length;

            Console.WriteLine("Средние значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        void IRemove.Remove_More_Than_100()
        {
            Console.WriteLine("Массив после удаления чисел, более 100 по модулю:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]}, ");
                }
            }
            Console.WriteLine();
        }
        void IPrint.Print(){
            Console.WriteLine("Одномер");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        public override void Print()
        {
            Console.WriteLine("Одномер");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}


