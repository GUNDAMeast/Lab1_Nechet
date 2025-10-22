using System.Collections.Specialized;
using System.Text;

namespace SMV_Lab1_Nechet
{
    class Lab1
    {
        //1.1
        public double Fraction(double x)
        {
            return (x - Math.Truncate(x));
        }

        //1.3
        public int CharToNum(char x)
        {
            return (int)x - '0';
        }

        //1.5
        public bool Is2Digits(int x)
        {
            return (Math.Abs(x) < 10) && (Math.Abs(x) > 99);
        }

        //1.7
        public bool IsInRange(int a, int b, int num)
        {
            int left = Math.Min(a, b);
            int right = Math.Max(a, b);
            return num >= left && num <= right;
        }

        //1.9
        public bool IsEqual(int a, int b, int c)
        {
            return (a == b) && (a == c);
        }

        //2.1
        public int Abs(int x)
        {
            //return Math.Abs(x);
            if (x < 0) x = -x;
            return x;
        }

        //2.3
        public bool Is35(int x)
        {
            return (x % 3 == 0) ^ (x % 5 == 0);
        }

        //2.5
        public int Max3(int x, int y, int z)
        {
            ///return Math.Max(Math.Max(x, y), z);

            int m = x;
            if (y > m)
            {
                m = y;
            }
            if (z > m)
            {
                m = z;
            }
            return m;
        }

        //2.7
        public int Sum2(int x, int y)
        {
            int sum = x + y;
            if ((sum >= 10) & (sum <= 19)) return 20;
            return sum;
        }

        //2.9
        public string Day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";

                case 2:
                    return "понедельник";

                case 3:
                    return "понедельник";

                case 4:
                    return "понедельник";

                case 5:
                    return "понедельник";

                case 6:
                    return "понедельник";

                case 7:
                    return "понедельник";

                default:
                    return ("Это не день недели");
            }
        }

        //3.1
        public string ListNums(int x)
        {
            var strBuild = new StringBuilder();
            if (x > 0)
                for (int i = 0; i <= x; i++)
                {
                    AppendWithSpace(strBuild, i);
                }
            else
                for (int i = 0; i <= x; i--)
                {
                    AppendWithSpace(strBuild, i);
                }
            return strBuild.ToString().Trim();
        }

        //3.1 method
        public void AppendWithSpace(StringBuilder sb, int val)
        {
            if (sb.Length > 0) sb.Append(' ');
            sb.Append(val);
        }

        //3.3
        public string Chet(int x)
        {
            var strBuild = new StringBuilder();
            if (x > 0)
                for (int i = 0; i <= x; i += 2)
                {
                    AppendWithSpace(strBuild, i);
                }
            else
                for (int i = 0; i <= x; i--)
                {
                    AppendWithSpace(strBuild, i);
                }
            return strBuild.ToString().Trim();
        }

        //3.5
        public int NumLen(long x)
        {
            long ax = Math.Abs(x);
            if (ax == 0) return 1;
            int count = 0;
            while (ax > 0)
                count++;
            ax /= 10;
            return count;
        }

        //3.7
        public void Square(int x)
        {
            if (x <= 0) return;
            string line = new('*', x);
            for (int i = 0; i < x; i++) Console.WriteLine(line);
        }
        
        //3.9
        public void RightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = x-i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //4.1
        public int FindFirst(int[] arr, int x)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

        //4.3
        public int MaxAbs(int[] arr)
        {
            int mx = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(mx)) mx = arr[i];
            }
            return mx;
        }

        //4.5
        public int[] Add(int[] arr, int[] ins, int pos)
        {
            int[] addmas = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; i++) addmas[i] = arr[i];
            for (int i = 0; i < ins.Length; i++) addmas[pos + i] = ins[i];
            for (int i = pos; i < arr.Length; i++) addmas[i+ins.Length] = arr[i];
            return addmas;
        }

        //4.7
        public int[] ReverseBack(int[] arr)
        {
            int[] addmas = new int[arr.Length];
            int k = arr.Length-1;
            for (int i = 0; i<arr.Length; i++)
            {
                addmas[i] = arr[k];
                k--;
            }
            return addmas;
        }

        //4.9
        public int[] FindAll(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) count++;
            }
            int[] addmas = new int[count];
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    addmas[count] = i;
                    count++;
                }                
            }
            return addmas;
        }
    }
}
