using FileIODemo2.Entities;

namespace FileIODemo2.Data
{
    public interface IContactsRepository
    {
        void SaveContact(Contact contactToSave);
        List<Contact> GetAllContacts();
    }
}
