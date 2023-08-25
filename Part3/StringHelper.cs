using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public static class StringHelper
    {
    
       
        public static string GetNameFromEmail(string email)
        {
            email = email[..^4];
            return email;
        }
    }
}
