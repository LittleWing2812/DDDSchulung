using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Domain
{
    public class RaumNummer
    {
        public RaumNummer(string raumNummer)
        {
            if(!Validate(raumNummer))
            {
                throw new Exception("RaumNummer ungültig");
            }
        }

        public string Value { get; private set; }

        // ToDo: 4-stellig, alles Ziffern 
        private bool Validate(string s)
        {
            return true;
        }
    }
}
