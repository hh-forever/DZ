using PetsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCat Bagira = new MyCat();
            Bagira.Meow(); // Метод Meow() из DLL
            Console.ReadLine();
        }
    }
}
