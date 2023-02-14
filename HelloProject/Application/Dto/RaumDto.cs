using HelloProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Application
{
    public class RaumDto
    {
        public RaumDto(Raum raum, string[] kurzBezeichnungen)
        {
            Raum = raum;
            KurzBezeichnungen = kurzBezeichnungen;
        }

        public Raum Raum { get; private set; }  
        public string[] KurzBezeichnungen { get; private set; }
    }
}
