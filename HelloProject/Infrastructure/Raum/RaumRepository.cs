using HelloProject.Domain;
using System.Collections.Generic;
using System.Linq;

namespace HelloProject.Infrastructure
{

    public class RaumRepository : List<Raum>, IRaumRepository
    {
        public bool Exists(RaumNummer nr)
        {
            return Get(nr) != null;
        }

        public Raum Get(RaumNummer nr)
        {
            return this.FirstOrDefault(raum => raum.RaumNummer.Value.Equals(nr.Value));
        }

        public Raum Get(int id)
        {
            return this.FirstOrDefault(raum => raum.Id == id);
        }

        public void Save(Raum raum)
        {
            Add(raum);
        }

        public bool HasPerson(int personId)
        {
            return this.Any(raum => raum.HasPerson(personId));
        }
    }
}
