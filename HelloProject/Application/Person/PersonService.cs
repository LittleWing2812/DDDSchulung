using HelloProject.Domain;
using System;

namespace HelloProject.Application
{
    public class PersonService
    {
        IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
       }

        public Person Create(string ldap, string name)
        {
            if (personRepository.Exists(ldap))
            {
                throw new Exception("gibz");
            }

            return new Person(ldap, name);
        }
    }
}

