using FileIODemo2.Data;
using FileIODemo2.Entities;

int choice = 1;
Console.WriteLine("Welcome to my Contacts Management System");
Console.WriteLine("-----------------------------------------");

IContactsRepository repo = new ContactsRepository();
while (choice != 3)
{
    try
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Create Contact");
        Console.WriteLine("2. View All Contacts");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Contact contact = CollectContactData();
                repo.SaveContact(contact); break;
            case 2:
                List<Contact> contacts = repo.GetAllContacts();
                DisplayAllContacts(contacts); break;
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static Contact CollectContactData()
{
    Contact c = new Contact();
    Console.Write("Enter Contact ID: ");
    c.ContactId = int.Parse(Console.ReadLine());
    Console.Write("Enter Contact Name: ");
    c.Name = Console.ReadLine();
    Console.Write("Enter Email ID: ");
    c.EmailID = Console.ReadLine();
    Console.Write("Enter Mobile Number: ");
    c.MobileNo = Console.ReadLine();
    Console.Write("Enter Location: ");
    c.Location = Console.ReadLine();
    return c;
}
static void DisplayAllContacts(List<Contact> contacts)
{
    Console.WriteLine("ID \t Name \t Email \t Mobile \t Location");
    foreach (Contact c in contacts)
    {
        Console.WriteLine($"{c.ContactId}\t{c.Name}\t{c.EmailID}\t{c.MobileNo}\t{c.Location}");
    }
}
