using DBDemo1.Entities;

namespace DBDemo1.Data
{
    public interface IContactsRepository
    {
        void Save(Contact contactToSave);
        void Delete(int id);

        Contact GetContact(int id);

        List<Contact> GetAllContacts();
    }
}
