using HelloProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Domain

{
    public class PersonRepository : List<Person>, IPersonRepository
    {
        public bool Exists(string LDAP)
        {
            return Get(LDAP) != null;
        }

        public Person Get(string LDAP)
        {
            return this.FirstOrDefault(person => person.LDAP.Equals(LDAP));
        }

        public Person Get(int id)
        {
            return this.FirstOrDefault(person => person.Id == id);
        }

        public void Save(Person person)
        {
            Add(person);
        }
    }
}