using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_code_dotnet.models
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ToPresent()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, e tenho {Age} anos!");
        }
    }
}