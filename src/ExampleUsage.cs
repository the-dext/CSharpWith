using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith
{
    using CSharpWith;

    public class Usage
    {
        public void TryIt()
        {
            var person1 = new Person().With(x =>
            {
                x.FirstName = "John";
                x.Surname = "Smith";
            }
            );

            var person2 = new Person()
                .With(
                    x => x.FirstName = "John",
                    x => x.Surname = "Smith");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}