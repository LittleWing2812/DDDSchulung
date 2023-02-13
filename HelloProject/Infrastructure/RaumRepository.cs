using HelloProject.Domain;
using HelloProject.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Infrastructure
{

    public class RaumRepository : List<Raum>, IRaumRepository
    {
        public bool Exists(RaumNummer nr)
        {
            return GetRaum(nr) != null;
        }

        public Raum GetRaum(RaumNummer nr)
        {
            return this.FirstOrDefault(raum => raum.RaumNummer.Value.Equals(nr.Value));
        }

        public Raum GetRaum(int id)
        {
            return this.FirstOrDefault(raum => raum.Id == id);
        }

        void SaveRaum(Raum raum)
        {
            Add(raum);
        }

        public bool RaumHasPerson(Person person)
        {
            return this.Any(raum => raum.HasPerson(person));
        }
    }
}
