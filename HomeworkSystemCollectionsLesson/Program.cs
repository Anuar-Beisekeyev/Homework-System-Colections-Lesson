using System;
using System.Collections.Generic;

namespace HomeworkSystemCollectionsLesson
{
    //	Создать коллекцию List<int>.Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции.Вывести на экран сумму элементов на четных позициях.
    //	Создать собственный тип коллекции, который наследует поведение обыкновенного списка, но реализует принцип пузырьковой сортировки внутри.

    class Program
    {
        static void Main(string[] args)
        {          

            Random random = new Random();
            int size = 10;
            var list = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(0, 100));
            }
            Console.Write("Исходный массив: ");

            foreach (int element in list)
            {                
                Console.Write(element + " ");
            }

            int larg = int.MinValue;
            int secondLarg = int.MinValue;
            foreach (int i in list)
            {
                if (i > larg)
                {
                    secondLarg = larg;
                    larg = i;
                }
                else if (i > secondLarg)
                    secondLarg = i;
            }
            Console.WriteLine();
            Console.WriteLine("Второе число с максимальным значением: " + secondLarg);
            int summa = 0;            
            int count = 1;
            
            foreach(int element in list)
            {
                if (count % 2 == 0)
                {
                    summa += element;
                }
                count++;
            }

            Console.WriteLine("Сумма чисел на четных позициях: " + summa);
            Console.WriteLine("-------------------------------------------\n");

            var mylist = new MyList<int>();
            for (int i = 0; i < size; i++)
            {
                mylist.Add(random.Next(0, 100));
            }
            Console.WriteLine("Отсортированный массив с помощью пузырковой сортировки:");
            mylist.BubbleSorting();
            foreach (var item in mylist)
            {
                Console.Write(item + " ");
            }
            
            


            Console.ReadLine();

        }       
       
    }
}
