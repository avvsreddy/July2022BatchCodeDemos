// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// File Search

// ask the user to enter a file name for search
// test.txt
// search the given file in entire hdd, if exist display the full path of the file



static void GetDriveInfo()
{
    DriveInfo[] drives = DriveInfo.GetDrives();
    foreach (var d in drives)
    {
        Console.WriteLine(d.Name);
        Console.WriteLine(d.AvailableFreeSpace);
    }
}

static void GetAllFiles()
{
    string[] files = Directory.GetFiles("C:\\Intel\\Logs");
    foreach (var item in files)
    {
        Console.WriteLine(item);
        File.Delete(item);
    }
}