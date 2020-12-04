using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLibrary
{
    public abstract class Cat

    {

        public string Name;

        public byte Age;

        public byte Weight;

        public abstract string Meow();

        public Cat()

        {

        }

        public Cat(string n, byte age, byte w)

        {

            Name = n;

            Age = age;

            Weight = w;

        }

    }

}
