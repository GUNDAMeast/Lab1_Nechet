using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMV_Lab1_Nechet
{
    class Lab1
    {
        //1.1
        public double Fraction(double x)
        {
            return x - (int)x;
            //return (x - Math.Truncate(x));
        }

        //1.3
        public int CharToNum(char x)
        {
            return (int)x - '0';
            //return (int)x - 48;
        }

        //1.5
        public bool Is2Digits(int x)
        {
            return ((x > 9) & (x < 100)) || ((x<-9) & (x>-100));
        }

        //1.7
        public bool IsInRange(int a, int b, int num)
        {
            int left = Math.Min(a,b);
            int right = Math.Max(a,b);
            return (num >= left) & (num <= right);
        }

        //1.9
        public bool IsEqual(int a, int b, int c)
        {
            return ((a == b) & (a == c));
        }

        //2.1
        public int Abs(int x)
        {
            if (x < 0) x = -x;
            return x;
        }

        //2.3
        public bool Is35(int x)
        {
            return (x%3==0) ^ (x%5==0);
        }

        //2.5
        public int Max3(int x, int y, int z)
        {
            if (x < y) x = y;
            if (x < z) x = z;
            return x;
            //return Math.Max(Math.Max(x, y), z);
        }

        //2.7
        public int Sum2(int x, int y)
        {
            int sum = x+y;
            if ((sum>9) & (sum<20)) return 20;
            return sum;
        }

        //2.9
        public string Day(int x)
        {
            switch(x)
                {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресение";
                default:
                    return "Это не день недели";
                }
        }

        //3.1
        public string ListNums(int x)
        {
            string line = "";
            if (x>=0)
                for (int i=0;i<=x;i++)
                {
                    line = line + Convert.ToString(i)+ " ";
                }
            else
                for (int i = 0; i >= x; i--)
                {
                    line = line + Convert.ToString(i) + " ";
                }
            return line.Trim();
        }

        //3.3
        public string Chet(int x)
        {
            string line = "";
            if (x>0)
                for (int i=0;i<=x;i=i+2)
                {
                    line = line + Convert.ToString(i)+ " ";
                }
            else
                for (int i = 0; i >= x; i = i - 2)
                {
                    line = line + Convert.ToString(i) + " ";
                }
            return line.Trim();
        }

        //3.5
        public int NumLen(long x)
        {
            if (x == 0) return 1;
            else
            {
                int count = 0;
                while (x != 0)
                {
                    count++;
                    x = x / 10;
                }
                return count;
            }
        }

        //3.7
        public void Square(int x)
        {
            for (int i=0;i<x;i++)
            {
                string s = new string('*', x);
                Console.WriteLine(s);
            }
        }

        //3.9
        public void RightTriangle(int x)
        {
            int spaces = x;
            for (int i=1;i<=x;i++)
            {
                spaces--;
                string s = new string(' ', spaces);
                string k = new string('*', i);
                Console.WriteLine($"{s}{k}");
            }
        }

        //4.1
        public int FindFirst(int[] arr, int x)
        {
            for (int i=0; i<arr.Length;i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

        //4.3
        public int MaxAbs(int[] arr)
        {
            int most = Math.Abs(arr[0]);
            for (int i = 1;i<arr.Length;i++)
            {
                if (Math.Abs(arr[i]) > most) most = Math.Abs(arr[i]);
            }
            return most;
        }
        
        //4.5
        public int[] Add(int[] arr, int[] ins, int pos)
        {
            int[] summas = new int[arr.Length + ins.Length];
            for (int i=0; i<pos; i++)
            {
                summas[i] = arr[i];
            }
            for (int i=0; i<ins.Length;i++)
            {
                summas[pos + i] = ins[i];
            }
            for (int i=pos;i<arr.Length;i++)
            {
                summas[ins.Length + i] = arr[i];
            }
            return summas;
        }
        
        //4.7
        public int[] ReverseBack(int[] arr)
        {
            int[] mas = new int[arr.Length];
            for (int i=0; i<arr.Length;i++)
            {
                mas[i] = arr[arr.Length-1 - i];
            }
            return mas;
        }

        //4.9
        public int[] FindAll(int[] arr, int x)
        {
            int count = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] == x) count++;
            }
            if (count == 0) Console.WriteLine("Данное число не входит в этот массив");
            int[] findmas = new int[count];
            count = 0;
            for (int i = 0; i<arr.Length;i++)
            {
                if (arr[i] == x)
                {
                    findmas[count] = i;
                    count++;
                }
            }
            return findmas;
        }
    }
}
