using Part3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static string Email { get; set; }

        public static int personCount = 0;

        public Person(string email)
        {
           Email = email;
        }

    


    }
}

