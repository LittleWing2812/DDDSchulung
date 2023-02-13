using HelloProject.Domain;
using HelloProject.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Service
{
    public class RaumService
    {
        
        public Raum CreateRaum(IRaumRepository raumListe, string nr, string name)
        {
            var raumNummer = new RaumNummer(nr);

            if(raumListe.Exists(raumNummer))
            {
                throw new Exception("gibz");
            }
            return null;
        }

        public void AddPerson(IRaumRepository raumRepository, int raumId, string LDAP, string name)
        {
            var raum = raumRepository.GetRaum(raumId);
            var person = new Person(LDAP, name);

            if(raumRepository.RaumHasPerson(person))
            {
                throw new Exception("Person bereits zugeordnet");
            }

            raum.AddPerson(person);
           
        }


    }
}
