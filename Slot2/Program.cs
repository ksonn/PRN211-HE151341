

/* using System;

namespace Slot2 {
    class Program
    {
       static void Main(string[] args)
        {
            string msg = "*welcome to C#.net**";
            Console.WriteLine("{0}", msg);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
        } 
    }

} */



/*using System;

namespace Slot2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Hello World";
            var myDouble = 0.5;
            Console.WriteLine("myInt is ac:{0} ", myInt.GetType.Name);
            Console.WriteLine("myBool is a :{0} ", myBool.GetType.Name);
            Console.WriteLine("myString is a :{0} ", myString.GetType.Name);
            Console.WriteLine("myDouble is a :{0} ", myDouble.GetType.Name);
            Console.ReadLine();

        }
    }
}*/

/*using System;

namespace Slot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 200.234;
            string name = "Soren";
            string str1 = string.Format("Name{0,6},Salary{1,7:N2}", name, salary);
            Console.WriteLine(str1);
            string str2 = $"Name{name,7},Salary{salary,8:N2}";
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}*/

/*using System;

namespace Slot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("Data Type Parsing");
            Console.WriteLine("Enter a String value");
            s = Console.ReadLine();
            Console.WriteLine("Enter a Double value");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Integer value");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Date value");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i:{i} , d:{d} , date:{date:dd/MM/yy}");
            Console.ReadLine();


        }
    }
}*/

using System;

namespace Slot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Use Digit Separators *****");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Double");
            Console.WriteLine(123_456.12);
            Console.Write("Hex");
            Console.WriteLine(0x_00_00_FF);
            Console.WriteLine("***** Use Binary Literals *****");
            Console.WriteLine("Sixteen: {0}" , 0b_0001_0000);
            Console.WriteLine("Thirty Two: {0}" , 0b_0010_0000);
            Console.WriteLine("Sixty Four: {0}" , 0b_0100_0000);
            Console.ReadLine();


        }
    }
}