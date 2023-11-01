using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNet7
{
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required string Surname { get; set; }
    }
}
