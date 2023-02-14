namespace HelloProject.Domain
{
    public interface IRaumRepository
    {
        bool Exists(RaumNummer nr);
        Raum Get(RaumNummer nr);
        Raum Get(int id);
        bool HasPerson(int personId);
        void Save(Raum raum);
    }
}