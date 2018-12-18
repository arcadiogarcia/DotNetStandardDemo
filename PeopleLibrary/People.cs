using System;
using System.Collections.Generic;

namespace PeopleLibrary
{
    public struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureURI { get; set; }
    }

    public class People
    {
        private static List<Person> knownPeople = new List<Person>(){
            new Person{
                FirstName = "Arcadio",
                LastName = "Garcia",
                PictureURI = "https://avatars2.githubusercontent.com/u/9416356?s=400&u=8b999523c0c59cf52989e95959e431b93edfc672&v=4"
            },
            new Person{
                FirstName = "David",
                LastName = "Hasselhoff",
                PictureURI = "https://c8.alamy.com/comp/EFA3H9/david-hasselhoff-knight-rider-1982-EFA3H9.jpg"
            },
            new Person{
                FirstName = "Nicholas",
                LastName = "Cage",
                PictureURI = "http://www.sickchirpse.com/wp-content/uploads/2011/09/Nicolas-Cage.jpeg"
            }
        };

        public static List<Person> GetPeople()
        {
            return knownPeople;
        }

        public static void AddPerson(Person p)
        {
            knownPeople.Add(p);
        }
    }
}
