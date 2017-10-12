
using System;
using System.Collections.Generic;
using System.IO;
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
            //Console.WriteLine(Tests.Test(1000, 2, null));
            //Console.WriteLine(Tests.Test(1001, 2, null));
            //Console.WriteLine(Tests.Test(9999, 2, null));
            //Console.WriteLine(Tests.Test(10000, 2, null));
            //Console.WriteLine(Tests.Test(10001, 2, null));
            //Console.WriteLine(Tests.Test(19999, 2, null));
            //Console.WriteLine(Tests.Test(20000, 2, null));
            //Console.WriteLine(Tests.Test(20001, 2, null));
            //Console.WriteLine(Tests.Test(39999, 2, null));
            //Console.WriteLine(Tests.Test(40000, 2, null));
            //Console.WriteLine(Tests.Test(2000, 2, null));
            //Console.WriteLine(Tests.Test(2000, 3, null));
            //Console.WriteLine(Tests.Test(2000, 5, null));
            //Console.WriteLine(Tests.Test(2000, 10, null));
            //Console.WriteLine(Tests.Test(2000, 10, 5));
            //Console.WriteLine(Tests.Test(2000, 15, 5));
            Console.WriteLine(Tests.Test(50000,100 , -1));

        }
    }
}
