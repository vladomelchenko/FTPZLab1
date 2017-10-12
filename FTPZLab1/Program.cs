
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FTPZLab1.Models;

namespace FTPZLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-1,-1:{0}       (false)", Tests.Test(-1,-1));
            Console.WriteLine("999,4:{0}       (false)", Tests.Test(999, 4));
            Console.WriteLine("1000,4:{0}       (true)", Tests.Test(1000, 4));
            Console.WriteLine("1001,4:{0}       (true)", Tests.Test(1001, 4));
            Console.WriteLine("9999,4:{0}       (true)", Tests.Test(9999, 4));
            Console.WriteLine("10000,4:{0}       (true)", Tests.Test(10000, 4));
            Console.WriteLine("10001,4:{0}       (true)", Tests.Test(10001, 4));
            Console.WriteLine("19998,4:{0}       (true)", Tests.Test(19998, 4));
            Console.WriteLine("19999,4:{0}       (true)", Tests.Test(19999, 4));
            Console.WriteLine("20000,4:{0}       (true)", Tests.Test(20000, 4));
            Console.WriteLine("39998,4:{0}       (true)", Tests.Test(39998, 4));
            Console.WriteLine("39999,4:{0}       (true)", Tests.Test(39999, 4));
            Console.WriteLine("40000,4:{0}       (false)", Tests.Test(40000, 4));

            Console.WriteLine("2000,0:{0}       (false)", Tests.Test(2000, 0));
            Console.WriteLine("2000,2:{0}       (true)", Tests.Test(2000, 2));
            Console.WriteLine("2000,3:{0}       (true)", Tests.Test(2000, 3));
            Console.WriteLine("2000,4:{0}       (true)", Tests.Test(2000, 4));
            Console.WriteLine("2000,5:{0}       (true)", Tests.Test(2000, 5));
            Console.WriteLine("2000,6:{0}       (true)", Tests.Test(2000, 6));
            Console.WriteLine("2000,9:{0}       (true)", Tests.Test(2000, 9));
            Console.WriteLine("2000,10:{0}       (false)", Tests.Test(2000, 10));
            Console.WriteLine("2000,11:{0}       (false)", Tests.Test(2000, 11));

        }
    }
}
