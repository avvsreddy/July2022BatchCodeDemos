using FileIODemo2.DomainExceptions;
using FileIODemo2.Entities;

namespace FileIODemo2.Data
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly string fileName = "e:/contact-list.txt";
        public List<Contact> GetAllContacts()
        {
            StreamReader reader = null;
            List<Contact> contacts = new List<Contact>();
            try
            {
                reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    // read line by line
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    // convert line into contact object

                    Contact contact = new Contact();
                    contact.ContactId = int.Parse(data[0]);
                    contact.Name = data[1];
                    contact.EmailID = data[2];
                    contact.MobileNo = data[3];
                    contact.Location = data[4];

                    // add contact obj into list
                    contacts.Add(contact);
                }
            }
            catch (Exception ex)
            {
                UnableToReadContactsException ex1 = new UnableToReadContactsException("Problem in reading contacts, try again", ex);
                throw ex1;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            // return the list
            return contacts;
        }

        public void SaveContact(Contact contactToSave)
        {
            StreamWriter sw = null;
            try
            {
                // open the writer stream
                sw = new StreamWriter(fileName, true);
                string contactCSV = $"{contactToSave.ContactId},{contactToSave.Name},{contactToSave.EmailID},{contactToSave.MobileNo},{contactToSave.Location}";
                sw.WriteLine(contactCSV);
            }
            catch (Exception ex)
            {
                // log
                // convert
                UnableToSaveContactException ex1 = new UnableToSaveContactException("Contact information is not saved, try again", ex);
                // re throw
                throw ex1;
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}
