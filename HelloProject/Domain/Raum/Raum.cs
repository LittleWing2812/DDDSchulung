using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Domain
{
    public class Raum
    {
        public int Id { get; private set; }
        public RaumNummer RaumNummer { get; private set; }
        public Name Name { get; private set; }
        private List<Person.Person> PersonenListe { get; set; }

        public void AddPerson(Person.Person person)
        {
            PersonenListe.Add(person);
        }
        public bool HasPerson(Person.Person person)
        {
            return PersonenListe.Any(item => item.Equals(person));
        }



    }
}
