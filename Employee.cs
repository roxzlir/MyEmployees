using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployees
{
    internal class Employee //Skapar en klass enligt anvisning
    {
        public int Id { get; set; } //Sätter propertys
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salery { get; set; }

        public Employee(int id, string name, string gender, int salery) //Gör en konstruktor för att kunna skapa lite olika objekt av klassen.
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salery = salery;
        }
    }
}
