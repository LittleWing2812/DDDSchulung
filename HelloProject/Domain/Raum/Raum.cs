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
        public List<int> PersonenIdListe { get; private set; }

        public void AddPerson(int personId)
        {
            if (HasPerson(personId))
            {
                throw new Exception("person existiert");
            }
            PersonenIdListe.Add(personId);
        }
        public bool HasPerson(int personId)
        {
            return PersonenIdListe.Contains(personId);
        }
    }
}
