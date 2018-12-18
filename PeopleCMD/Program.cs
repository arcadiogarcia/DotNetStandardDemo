using System;

namespace PeopleCMD
{
    class Program
    {
        static void Main(string[] args)
        {
           while(MainMenu());
        }

        static bool MainMenu(){
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Print list of people");
            Console.WriteLine("2 - Add a person");
            Console.WriteLine("3 - Exit");
            string userInput = Console.ReadLine();
            switch(userInput){
                case "1":
                    PrintPeople();
                    break;
                case "2":
                    AddPerson();
                    break;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Input not recognized, try again");
                    break;
            }
            return true;
        }

        static void PrintPeople(){
            Console.WriteLine();
            foreach(var person in PeopleLibrary.People.GetPeople()){
                Console.WriteLine($"{person.LastName}, {person.FirstName}");
            }
        }

        static void AddPerson(){
            Console.WriteLine();
            Console.WriteLine("Insert first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Insert last name:");
            string lastName = Console.ReadLine();
            PeopleLibrary.People.AddPerson(new PeopleLibrary.Person{
                FirstName = firstName,
                LastName = lastName,
                PictureURI = null
            });
        }
    }
}
