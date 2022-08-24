using EFDemo1.Data;
using EFDemo1.Entities;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fetch();
            //Edit();
        }

        private static void Edit()
        {
            // Edit sachins mobile number
            // get the sachin's object
            ContactsDbContext db = new ContactsDbContext();
            var sachin = (from c in db.Contacts
                          where c.Name == "SAchin"
                          select c).FirstOrDefault();

            sachin.Mobile = "12345678";
            db.SaveChanges();
        }

        private static void Delete()
        {
            // delete a contact
            ContactsDbContext db = new ContactsDbContext();
            //Contact contactToDelete = (from c in db.Contacts
            //                          where c.ContactID == 1
            //                          select c).FirstOrDefault();

            // get the object to delete
            var contactToDelete = db.Contacts.Find(1);
            // remove the object from dbset
            db.Contacts.Remove(contactToDelete);
            // save the changes to db
            db.SaveChanges();
        }

        private static void Create()
        {
            // Create new Contact
            ContactsDbContext db = new ContactsDbContext();
            Contact c = new Contact();
            Console.Write("Enter contact name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Email Id: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Mobile Number: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Location: ");
            c.Location = Console.ReadLine();

            db.Contacts.Add(c);
            db.SaveChanges();
        }

        private static void Fetch()
        {
            // fetch all contacts
            ContactsDbContext db = new ContactsDbContext();
            // linq to entites
            var contacts = from c in db.Contacts
                           select c;

            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.Name,15}{item.Email,15}{item.Mobile,15}{item.Location,15}");
            }
        }
    }
}