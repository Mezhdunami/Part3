using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex");
            Person person2 = new Person("Goku");
            Person person3 = new Person("Max");
            Console.WriteLine(Person.personCount);
        }
    }
}
