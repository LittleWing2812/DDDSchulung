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
            if (personRepository.Get(personId) == null)
            {
            }
            
            if( raumRepository.Get(raumId) == null)
            {
            }

            raumRepository.Get(raumId).AddPerson(personId);
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
