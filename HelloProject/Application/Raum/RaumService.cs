using HelloProject.Domain;
using System;
namespace HelloProject.Application
{
    public class RaumService
    {
        IRaumRepository raumRepository;

        public RaumService(IRaumRepository raumRepository)
        {
            this.raumRepository = raumRepository;
        }

        public Raum Create(string nr, string name)
        {
            var raumNummer = new RaumNummer(nr);

            if(raumRepository.Exists(raumNummer))
            {
                throw new Exception("gibz");
            }
            return new Raum();
        }


    }
}
