namespace HelloProject.Domain
{
    public interface IPersonRepository
    {
        bool Exists(string LDAP);
        Person Get(int id);
        Person Get(string LDAP);
        void Save(Person person);
    }
}