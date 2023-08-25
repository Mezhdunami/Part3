using System.Security.Cryptography.X509Certificates;

namespace part1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static int personCount = 0;

        public Person(string name)
        {
            Name = name;
            personCount++;
        }
            

    }
}