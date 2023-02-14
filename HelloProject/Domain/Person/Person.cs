using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Domain
{
    public class Person
    {
        public Person(string LDAP, string Name)
        {
            /*
            Validierung ...
            Dr.
            von van ...
            */

        }

        public bool Equals(Person obj)
        {
            return  string.Equals(LDAP, obj.LDAP);
        }
        public int Id { get; private set; }

        public string LDAP { get; private set; }
        public string Name { get; private set; }
        /*
         
         */
        public string KurzBezeichnung => $"{Name} ({LDAP})";
    }
}
