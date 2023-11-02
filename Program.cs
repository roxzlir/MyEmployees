using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;

namespace MyEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar 5 st objekt från klassen Employee
            Employee emp1 = new Employee(101, "Emil", "Male", 35000);
            Employee emp2 = new Employee(102, "Angelica", "Female", 36000);
            Employee emp3 = new Employee(103, "Victor", "Male", 32000);
            Employee emp4 = new Employee(104, "Sabina", "Female", 35500);
            Employee emp5 = new Employee(105, "Ulrika", "Female", 33800);
            
            Stack<Employee> stackEmp = new Stack<Employee>(); //Skapar en stack, kallar dem stackEmp
            stackEmp.Push(emp1); //Använder mig av Push för att lägga in alla mina objekt i stacken
            stackEmp.Push(emp2);
            stackEmp.Push(emp3);
            stackEmp.Push(emp4);
            stackEmp.Push(emp5);

            Console.WriteLine("Print all added in stack: ");
            foreach(var emp in stackEmp) //Gör en foreach loop för att få utskrift av allt i stacken
            {
                Console.WriteLine($"- {emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salery}");
                Console.WriteLine("Items in the stack: " + stackEmp.Count());
                //Kör med metoden Count för att få ut antalet items i min stack
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Retrive using Pop:");
            //Raderar ut ett objekt ur stacken med Pop metoden, för att få fram vilken det är som raderas
            //ur stacken lagrar jag den i objekt e1 och skriver sen ut den med WriteLine
            Employee e1 = stackEmp.Pop();
            Console.WriteLine($"- {e1.Id} - {e1.Name} - {e1.Gender} - {e1.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count()); //Kör count igen efter varje Pop!

            Employee e2 = stackEmp.Pop();
            Console.WriteLine($"- {e2.Id} - {e2.Name} - {e2.Gender} - {e2.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count());

            Employee e3 = stackEmp.Pop();
            Console.WriteLine($"- {e3.Id} - {e3.Name} - {e3.Gender} - {e3.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count());

            Employee e4 = stackEmp.Pop();
            Console.WriteLine($"- {e4.Id} - {e4.Name} - {e4.Gender} - {e4.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count());

            Employee e5 = stackEmp.Pop();
            Console.WriteLine($"- {e5.Id} - {e5.Name} - {e5.Gender} - {e5.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count());

            stackEmp.Push(emp1); //Pushar in objekten igen
            stackEmp.Push(emp2);
            stackEmp.Push(emp3);
            stackEmp.Push(emp4);
            stackEmp.Push(emp5);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Look in stack with Peek:");
            Employee em1 = stackEmp.Peek(); //Kör Peek metoden för att kika i stacken, samma här lagrar jag
                                            //de item jag får kolla på i ett objekt för utskrift
            Console.WriteLine($"- {em1.Id} - {em1.Name} - {em1.Gender} - {em1.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count()); //Kör count men Peek rör aldrig
                                                                          //själva stacken, allt ligger kvar

            Employee em2 = stackEmp.Peek(); //Kör Peek igen men man ser ju alltid bara den som ligger överst i
                                            //stacken (Alltså de objekt jag pushat in sist i stacken)
            Console.WriteLine($"- {em2.Id} - {em2.Name} - {em2.Gender} - {em2.Salery}");
            Console.WriteLine("Items in the stack: " + stackEmp.Count());

            Console.WriteLine("--------------------------------------");

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 }; //Skapar lista och 
            //lägger till objekten direkt när jag skapar listan
            if (employees.Contains(emp2)) //Kör en if sats där jag har med Contains metoden i villkoret, om
                                          //objekt emp2 finns med i listan skrivs första texten ut, annars andra
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine("--------------------------------------");

            Console.Write("First male in list: ");
            Employee emMale = employees.Find(x => x.Gender == "Male"); //Här kör jag metoden Find, sätter ett 
            //villkor/predikat som uppfylls för att den ska köra sökningen, sen väljer jag att sortera ut stringen
            //"Male" i Gender propertyn. Hittar då ut den första i listan som uppfyller sökningen.
            Console.WriteLine($"- {emMale.Id} - {emMale.Name} - {emMale.Gender} - {emMale.Salery}");
            //Lagrade resultat av Find metoden i emMale för att sen kunna skriva ut den.

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("All males in list: ");
            List<Employee> maleList = employees.FindAll(x => x.Gender == "Male"); //Kör med FindAll metoden med
            //samma premiss som i Find, men då jag nu får flera resultat så lagrar jag dem i en ny lista 
            //som jag sen skriver ut i en foreach loop
            foreach (var maleEmp in maleList)
            {
                Console.WriteLine($"- {maleEmp.Id} - {maleEmp.Name} - {maleEmp.Gender} - {maleEmp.Salery}");
            }

        }
    }
}