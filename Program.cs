using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysParent[] arraysParents = new ArraysParent[3];
            Console.WriteLine("Ввод мвссивов с клавиатуры?");
            if(Console.ReadLine() == "Да")
            {
                Console.WriteLine("Задачи на одномерные массивы");
                arraysParents[0] = new One_dimension(true);
                Console.WriteLine("Задачи на двумерные массивы");
                arraysParents[1] = new Two_dimension(true);
                Console.WriteLine("Задачи на зубчатые массивы");
                arraysParents[2] = new Jagged(true);
                
                for (int i = 0; i < arraysParents.Length; i++)
                {
                    arraysParents[i].Print();
                    arraysParents[i].Getmiddle();
                }
                IRemove oneDim = new One_dimension(true);
                oneDim.Remove_More_Than_100();
                IPrint[] print = new IPrint[4];
                print[0] = new One_dimension(true);
                print[1] = new Two_dimension(true);
                print[2] = new Jagged(true);
                print[3] = new Day();
                for(int i= 0;i<print.Length;i++ ){
                    print[i].Print();
                }


            }
            if(Console.ReadLine() == "Нет")
            {
                arraysParents[0] = new One_dimension(false);
                arraysParents[1] = new Two_dimension(false);
                arraysParents[2] = new Jagged(false);
                for (int i = 0; i < arraysParents.Length; i++)
                {
                    arraysParents[i].Print();
                    arraysParents[i].Getmiddle();

                }
            }

        }
    }
}