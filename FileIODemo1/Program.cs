




// read all the names from file and display

StreamReader reader = new StreamReader("e:/nameslist.txt");
string name;
while (!reader.EndOfStream)
{
    name = reader.ReadLine();

    Console.WriteLine(name);
}
//string allNames = reader.ReadToEnd();
reader.Close();
//Console.WriteLine(allNames);



static void SaveData()
{
    StreamWriter writer = null;
    try
    {
        Console.WriteLine("Enter person name");

        string pName = Console.ReadLine();

        writer = new StreamWriter("e:/nameslist.txt", true);
        writer.WriteLine(pName);
        // exp


        //writer.Close();
    }
    //catch (Exception ex)
    //{
    //    //writer.Close();
    //}
    finally
    {
        writer.Close();
    }
}