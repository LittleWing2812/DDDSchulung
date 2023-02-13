namespace HelloProject.Domain
{
    public interface IRaumRepository
    {
        bool Exists(RaumNummer nr);
        Raum GetRaum(RaumNummer nr);
        Raum GetRaum(int id);
        bool RaumHasPerson(Person.Person person);
    }
}