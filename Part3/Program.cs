using Part3;
using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        //Person person1 = new Person("Alex");
        //Person person2 = new Person("Goku");
        //Person person3 = new Person("Max");
        //Console.WriteLine("Person count is:" + Person.personCount);
        //Person person4 = new Person("Suzy");
        //Person person5 = new Person("Mazda");
        //Console.WriteLine("Person count is:" + Person.personCount);

       

       var d = StringHelper.GetNameFromEmail("YuriS.com");
        Console.WriteLine(d);

    }
}
