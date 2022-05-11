using System;

namespace RP_Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, would you like to display or add to the resturant register?");
            String input = "";

            List<Employe> EmployeList = new List<Employe>();
            EmployeList.Add(new Employe("Lars","Ove",25000));
            EmployeList.Add(new Employe("Anna", "Ekström", 25000));
            EmployeList.Add(new Employe("Davis", "Elm", "Oskarson", 25000));

            while (input!="Quit"|| input != "quit" || input != "q")
            {
                Console.WriteLine("\nInsert next comand:");
                input = Console.ReadLine();

                if (input.Contains("add")|| input.Contains("Add"))
                {
                    Console.WriteLine("Write the full name of the new enployer!");

                    String name = Console.ReadLine();

                    string FN = name.Split(' ')[0];
                    string SN = null;
                    string LN = name.Split(' ')[1];
                    if (name.Split(' ').Length >2)
                    {
                        SN = name.Split(' ')[1];
                        LN = name.Split(' ')[2];
                    
                    }

                    Console.WriteLine("Write the Monthly Salary that they would recive, in swedish sek.");

                    int Sal = Int32.Parse(Console.ReadLine());

                    if (SN!=null)
                    {
                        EmployeList.Add(new Employe(FN, SN, LN, Sal));
                    }
                    else
                    {
                        EmployeList.Add(new Employe(FN, LN, Sal));
                    }
                }
                else if (input.Contains("Display") || input.Contains("display"))
                {
                    Console.WriteLine("Nuber of employes: "+EmployeList.Count());
                    foreach (Employe E in EmployeList)
                    {
                        Console.WriteLine(E.getFName() + " " + E.getSName() + " " + E.getLName() + " - Salary: " + E.getSalary() + "kr");
                    }

                }
                else if (input.Contains("Help") || input.Contains("help") || input.Contains("h") || input.Contains("?"))
                {
                    Console.WriteLine("Add: Resister a new employer.");
                    Console.WriteLine("Display: Print all employes.");
                    Console.WriteLine("Quit: Terminates the program.");
                }
                else if (input == null)
                {
                Console.WriteLine("Please insert valid input.");
                }

            }
        }
                
    }
    public class Employe{

        public Employe(string FN, string LN, int S)
        {
            FirstName = FN;
            LastName = LN;
            Salary = S;
        }
        public Employe(string FN,string SN, string LN, int S)
        {
            FirstName = FN;
            SecondName = SN;
            LastName = LN;
            Salary = S;
        }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string SecondName { get; set; }
        private int Salary { get; set; }

        public string getFName()
        {
            return FirstName;
        }
        public string getSName()
        {
            return SecondName;
        }
        public string getLName()
        {
            return LastName;
        }
        public int getSalary()
        {
            return Salary;
        }
    }
    
}
