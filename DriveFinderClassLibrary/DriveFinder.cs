namespace DriveFinderClassLibrary
{
    public class DriveFinder : IDriveFinder
    {
        public List<string> GetDrives()
        {
            List<string> drives = new List<string>();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                drives.Add(drive.Name);
            }
            return drives;
        }
    }
}
