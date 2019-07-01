using System;

namespace Индексатор_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int size = Convert.ToInt32(Console.ReadLine());

            MyClass myClass = new MyClass(size);

            for(int k = 1; k < size; k++)
            {
                myClass[k] = k + 1;
            }

            Console.WriteLine(myClass);
            for (int k = 0; k < size; k++)
            {
                Console.WriteLine($"Итоговый массив: {myClass[k]} ");
            }
            Console.ReadKey();
        }

        class MyClass
        {
            public int[] arr;
            
            public int this [int k]
            {
                get
                {
                    return arr[k];
                }
                set
                {
                    arr[k] = value;
                }
            }


            public MyClass(int _size)
            {
                arr = new int[_size];
            }
        }
    }
}
