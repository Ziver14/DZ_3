using System.Runtime.CompilerServices;

namespace DZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Квадрат
            Draw('=', 5);

            Console.WriteLine("\n\n");

            //Задача 2. Палиндром

            Console.WriteLine(Palindrom(1221));

            Console.WriteLine("\n\n");

            //Задача 3. Фильтрация


            int[] arr = new int[10];
            int[] arr_filtr = new int[5];
            Random r = new Random();
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = r.Next(1, 10);
                Console.Write(arr[i] + "  ");
            }

            Console.WriteLine("\nМассив для фильтрации:");
            for (int i = 0; i < arr_filtr.Length; ++i)
            {
                arr_filtr[i] = r.Next(1, 5);
                Console.Write(arr_filtr[i] + "  ");
            }
            arr = Filtr(arr, arr_filtr);
            Console.WriteLine("\nМассив после фильтрации:");
            foreach (int i in arr)
                Console.Write(i + "  ");

            Console.WriteLine("\n\n");

            // Задача 4 Сайт
            Web sait = new Web();
            Console.WriteLine("Введите имя сайта:");
            sait.Name_ = Console.ReadLine();
            Console.WriteLine("Введите URL сайта:");
            sait.Url_ = Console.ReadLine();
            Console.WriteLine("Введите IP сайта");
            sait.IP_ = Console.ReadLine();
            Console.WriteLine("Введите описание сайта:");
            sait.Description_ = Console.ReadLine();
            Console.WriteLine("\n");
            sait.Print();

            Console.WriteLine("\n\n");

            // Задача 5 Журнал
           Journal jour = new Journal();
            Console.WriteLine("Введите название журнала");
            jour.name_ = Console.ReadLine();
            Console.WriteLine("Введите дату основания журнала");
            jour.dateTime_=Console.ReadLine();
            Console.WriteLine("Введит телефон журнала");
            jour.phone_ = Console.ReadLine();
            Console.WriteLine("Введите email журнала");
            jour.email_ = Console.ReadLine();
            Console.WriteLine("\n");
            jour.Print();

            //Задача 6 Магазин
            Shop shop = new Shop();
            Console.WriteLine("Введите название магазина");
            shop.name_ = Console.ReadLine();
            Console.WriteLine("Введите описание магазина");
            shop.descrition_ = Console.ReadLine();
            Console.WriteLine("Введит телефон магазина");
            shop.phone_ = Console.ReadLine();
            Console.WriteLine("Введите email магазина");
            shop.email_ = Console.ReadLine();
            Console.WriteLine("\n");
            shop.Print();
           





            //Метод вывода квадрата из символов
            static void Draw(char sym, int size)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(sym + " ");
                    }
                    Console.WriteLine();
                }
            }

            //Метод проверки на палиндром
            static bool Palindrom(int num)
            {
                bool result = true;
                string str = Convert.ToString(num);
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] == str[str.Length - 1 - i])
                        continue;
                    else
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }

            //Метод фильтраци массива
            static int[] Filtr(int[] arr, int[] filtr)
            {
                for (int i = 0; i < filtr.Length; ++i)
                {
                    int index = Array.IndexOf(arr, filtr[i]);
                    while (index != -1)
                    {
                        int[] tmp = new int[arr.Length - 1];
                        for (int j = 0; j < arr.Length; ++j)
                        {
                            if (j < index)
                                tmp[j] = arr[j];
                            if (j == index)
                                continue;
                            if (j > index)
                                tmp[j - 1] = arr[j];
                        }
                        arr = tmp;
                        index = Array.IndexOf(arr, filtr[i]);
                    }
                }
                return arr;
            }


        }




    }
}


