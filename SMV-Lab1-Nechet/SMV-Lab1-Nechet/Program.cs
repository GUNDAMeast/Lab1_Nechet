using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SMV_Lab1_Nechet
{
    class Program
    {
        static void Main(string[] args)
        {
            var InputCheck = new InputCheck();
            var Lab1 = new Lab1();

            bool stopTasks = false;
            string answer;

            int k = 1;
            string[][] tasksArray = new string[4][];
            for (int i = 0; i<tasksArray.Length; i++)
            {
                tasksArray[i] = new string[5];
                k = 1;
                for (int j = 0; j < tasksArray[i].Length; j++)
                {
                    tasksArray[i][j] = (i + 1) + "." + k;
                    k = k + 2;
                }
            }

            while (stopTasks == false)
            {
                Console.WriteLine("\nКакое задание выполнить?");
                for (int i = 0; i < tasksArray.Length; i++)
                {
                    for (int j = 0; j < tasksArray[i].Length; j++)
                        Console.Write(tasksArray[i][j] + "    ");
                    Console.WriteLine();
                }
                Console.WriteLine("Вы можете прекратить выполнение заданий если введёте 0.");
                answer = Console.ReadLine();
                Console.Clear();

                switch (answer)
                {
                    case "0":
                        stopTasks = true;
                        break;
                    
                    case "1.1":
                        Console.WriteLine("\n1.1 - Дробная часть");
                        Console.WriteLine("Результат: " + Lab1.Fraction(InputCheck.CheckDouble()));
                        break;
                    case "1.3":
                        Console.WriteLine("\n1.3 - Букву в число");
                        Console.WriteLine("Результат: " + Lab1.CharToNum(InputCheck.CheckNumChar()));
                        break;
                    case "1.5":
                        Console.WriteLine("\n1.5 - Двузначное");
                        Console.WriteLine("Результат: " + Lab1.Is2Digits(InputCheck.CheckInt()));
                        break;
                    case "1.7":
                        Console.WriteLine("\n1.7 - Диапазон");
                        Console.WriteLine("Результат: " + Lab1.IsInRange(InputCheck.CheckInt(), InputCheck.CheckInt(), InputCheck.CheckInt()));
                        break;
                    case "1.9":
                        Console.WriteLine("\n1.9 - Равенство");
                        Console.WriteLine("Результат: " + Lab1.IsEqual(InputCheck.CheckInt(), InputCheck.CheckInt(), InputCheck.CheckInt()));
                        break;

                    case "2.1":
                        Console.WriteLine("\n2.1 - Модуль числа");
                        Console.WriteLine("Результат: " + Lab1.Abs(InputCheck.CheckInt()));
                        break;
                    case "2.3":
                        Console.WriteLine("\n2.3 - Тридцать пять");
                        Console.WriteLine("Результат: " + Lab1.Is35(InputCheck.CheckInt()));
                        break;
                    case "2.5":
                        Console.WriteLine("\n2.5 - Тройной максимум");
                        Console.WriteLine("Результат: " + Lab1.Max3(InputCheck.CheckInt(), InputCheck.CheckInt(), InputCheck.CheckInt()));
                        break;
                    case "2.7":
                        Console.WriteLine("\n2.7 - Двойная сумма");
                        Console.WriteLine("Результат: " + Lab1.Sum2(InputCheck.CheckInt(), InputCheck.CheckInt()));
                        break;
                    case "2.9":
                        Console.WriteLine("\n2.9 - День недели");
                        Console.WriteLine("Результат: " + Lab1.Day(InputCheck.CheckInt()));
                        break;
                    
                    case "3.1":
                        Console.WriteLine("\n3.1 - Числа подряд");
                        Console.WriteLine("Результат: " + Lab1.ListNums(InputCheck.CheckInt()));
                        break;
                    case "3.3":
                        Console.WriteLine("\n3.3 - Чётные числа");
                        Console.WriteLine("Результат: " + Lab1.Chet(InputCheck.CheckInt()));
                        break;
                    case "3.5":
                        Console.WriteLine("\n3.5 - Длина числа");
                        Console.WriteLine("Результат: " + Lab1.NumLen(InputCheck.CheckLong()));
                        break;
                    case "3.7":
                        Console.WriteLine("\n3.7 - Квадрат");
                        Lab1.Square(InputCheck.CheckIntPlus());
                        break;
                    case "3.9":
                        Console.WriteLine("\n3.9 - Правый треугольник");
                        Lab1.RightTriangle(InputCheck.CheckIntPlus());
                        break;
                    
                    case "4.1":
                        Console.WriteLine("\n4.1 - Поиск первого значения");
                        Console.WriteLine("Результат: " + Lab1.FindFirst(InputCheck.CheckIntMas(), InputCheck.CheckInt()));
                        break;
                    case "4.3":
                        Console.WriteLine("\n4.3 - Поиск максимального");
                        Console.WriteLine("Результат: " + Lab1.MaxAbs(InputCheck.CheckIntMas()));
                        break;
                    case "4.5":
                        Console.WriteLine("\n4.5 - Добавление массива в массив");
                        int[] x1 = InputCheck.CheckIntMas();
                        int posInX1 = InputCheck.CheckIntPos(x1);
                        InputCheck.PrintMas(Lab1.Add(x1, InputCheck.CheckIntMas(), posInX1));
                        break;
                    case "4.7":
                        Console.WriteLine("\n4.7 - Возвратный реверс");
                        InputCheck.PrintMas(Lab1.ReverseBack(InputCheck.CheckIntMas()));
                        break;
                    case "4.9":
                        Console.WriteLine("\n4.9 - Все вхождения");
                        InputCheck.PrintMas(Lab1.FindAll(InputCheck.CheckIntMas(), InputCheck.CheckInt()));
                        break;
                    
                    default:
                        Console.WriteLine("Нет такого задания!");
                        break;
                }
            }
            Console.WriteLine("Выполнение заданий было прекращено.");
        }
    }
}
