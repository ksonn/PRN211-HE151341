

/* using System;

namespace Slot3
{
    internal class Program
    {

        static void MyMethod(int a, ref int b, out int c) {
            a = 3;
            b = 4;
            c = 5;
        }
        static void Main(string[] args)
        {
            int x=1 , y=2 ,z;
            MyMethod(x, ref y, out z);
            Console.WriteLine($"x:{x},y:{y},z:{z}");
            Console.ReadLine();
        }
    }
} 
---------------------------------------------------------------------------------------*/


/*using System;

namespace Slot3
{
    internal class Program
    {
        static void SumArray(out int s, params int[] list) {
            int i;
            s = 0;
            for (i = 0; i < list.Length; i++) {
                s += list[i];    
            }
        }
        static void Main(string[] args)
        {
            int s;
            SumArray(out s, 1, 2, 3, 4) ;
            Console.WriteLine($"s={s}");
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            SumArray(out s, myIntArray);
            Console.WriteLine($"s={s}");
            SumArray(out s);
            Console.WriteLine($"s={s}");
            Console.ReadLine();
        }
    }
}
-----------------------------------------------------------------------------------------------*/

/*using System;

namespace Slot3
{
    internal class Program
    {
        static int[] number = { 1, 2, 3, 4, 5 };
        static ref int FindNumber(int target) { 
            bool flag = true;
            ref int value = ref number[0];
            for (int ctr = 0; ctr < number.Length && flag == true; ctr++)
            {
                if (number[ctr] == target)
                    value = ref number[ctr];
                flag = false;

            }
        }
            return ref value ;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
------------------------------------------------------------------------------------------------------*/

/*using System;

namespace Slot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            void AddValue(int a , int b) {
                Console.WriteLine("Value of a is : " + a);
                Console.WriteLine("Value of b is : " + b);
                Console.WriteLine("Value of x is : " + x);
                Console.WriteLine("Value of y is : " + y);
                Console.WriteLine("Sum: {0}", a + b + x + y);
                Console.WriteLine();
            }
            AddValue(3, 4);
            AddValue(5, 6);
            Console.ReadLine();
        }
    }
}
---------------------------------------------------------------------------------------------------------*/

/*using System;

namespace Slot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void AreaOfCircle(double a)
            {
                double ar;
                Console.WriteLine("Radius of the circle : " + a);
                ar = 3.14 * a * a;
                Console.WriteLine("Area of circle : " + ar);
                Circumference(a);
                static void Circumference(double radii)
                {
                    double cr;
                    cr = 2 * 3.14 * radii;
                    Console.WriteLine($"Cirumference of the circle is : {cr:N2}");

                }
            }
                AreaOfCircle(10);
                Console.WriteLine();
            
        }
    }
}
---------------------------------------------------------------------------------------------------------------*/

/*using System;

namespace Slot3
{
    internal class Program
    {
        static (int sum, int count) MyMethod(int[] values)
        {
            var r = (sum: 0, count: 0);
            for (int i = 0; i < values.Length; i++)
            {
                if (IsEvenNumber(values[i]))
                {
                    r.sum += values[i];
                    r.count++;
                }
            }

            return r;
            bool IsEvenNumber(int n)
            {
                return n % 2 == 0;
            }
        }
            static void Main(string[] args)
            {
                int[] number = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
                var (sum, count) = MyMethod(number);
                Console.WriteLine($"Sum: {sum} , Count: {count}");
                Console.WriteLine();
            }
        }
    }
----------------------------------------------------------------------------------------------------------------*/

/*using System;

namespace Slot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "12", "Hello", "3.14", "20" };
            for (int i = 0; i < stringArray.Length; i++) {
                if (int.TryParse(stringArray[i], out _))
                    Console.WriteLine($"{stringArray[i]} : valid");
                else
                    Console.WriteLine($"{stringArray[i]} : invalid");

            }
            Console.ReadLine();
        }
    }
}
-----------------------------------------------------------------------------------------------------------------*/\

using System;

namespace Slot3
{
    internal class Program
    {
        static (string first , string middle , string last) SplitNames(string fullName)
        {
            string[] strArray = fullName.Split(' ');
            return (strArray[0], strArray[1], strArray[2]);
        }
        static void Main(string[] args)
        {
            var (first, _, last) = SplitNames("Nguyen Dang Quang");
            Console.WriteLine($"{first}:{last}");
            Console.ReadLine();
        }
    }
}

