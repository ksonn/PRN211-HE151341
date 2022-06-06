/* using System;

namespace Slot4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car wwPolo = new Car();
            wwPolo.Make = "2001";
            wwPolo.Model = "Quang";
            wwPolo.Accelerating();
            wwPolo.Braking();
            Console.ReadLine();
        }
    }
}
-------------------------------------------------------------*/

/* using System;

namespace Slot4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.CustomerID = 1000;
            Console.WriteLine($"ID:{obj.CustomerID} , Name:{obj.CustomerName}");
            obj.CustomerID = 2000;
            obj.CustomerName = "Jack";
            obj.Print();
            Console.ReadLine();
        }
    }
}
----------------------------------------------------------------*/

/*using System;

namespace Slot4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass obj = new MyClass() {x = 1 };
            Console.WriteLine($"x:{obj.x} , y:{obj.y}");
            MyClass obj1 = new MyClass();
            Console.WriteLine($"x:{obj1.x} , y:{obj1.y}");
            MyClass obj2 = new MyClass(30,50);
            Console.WriteLine($"x:{obj2.x} , y:{obj2.y}");
            Console.ReadLine();
        }
    }
}
----------------------------------------------------------------*/

using System;

namespace Slot4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass obj = new MyClass() { x = 1 };
            Console.WriteLine($"x:{obj.x} , y:{obj.y}");
            MyClass obj1 = new MyClass();
            Console.WriteLine($"x:{obj1.x} , y:{obj1.y}");
            MyClass obj2 = new MyClass(30, 50);
            Console.WriteLine($"x:{obj2.x} , y:{obj2.y}");
            Console.ReadLine();
        }
    }
}