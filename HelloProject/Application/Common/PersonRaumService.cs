using HelloProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Application.Common
{
    public class PersonRaumService
    {
        IPersonRepository personRepository;
        IRaumRepository raumRepository;
        public PersonRaumService(IPersonRepository personRepository, IRaumRepository raumRepository)
        {
            this.personRepository = personRepository;
            this.raumRepository = raumRepository;
        }

        public void PersonZuRaum(int personId, int raumId)
        {
            raumRepository.Get(raumId).AddPerson(personId);
        }

        public void PersonZuRaum(string ldap, string raumNummerValue)
        {
            var person = personRepository.Get(ldap);
            var raum = raumRepository.Get(new RaumNummer(raumNummerValue));

            PersonZuRaum(person.Id, raum.Id);
        }

        public RaumDto Get(int raumId)
        {
            var list = new List<string>();
            var raum = raumRepository.Get(raumId);
            raum.PersonenIdListe.ForEach(item => list.Add(personRepository.Get(item).KurzBezeichnung));
            return new RaumDto(raum, list.ToArray());
        }

    }
}
