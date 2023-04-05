namespace task1;

public static class WorkingWithDirs
{
    public static void RemoveDir(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        if (Directory.Exists(path))
        {
            Directory.Delete(path,true);
        }
        else
        {
            Console.WriteLine("Directory does not exist");
        }
    }
    public static void MoveDir(string what, string to)
    {
        what = Path.Combine(Directory.GetCurrentDirectory(), what);
        if (Directory.Exists(what))
        {
            if (!Directory.Exists(to))
            {
                Directory.Move(what,to);
            }
            else
            {
                Console.WriteLine("Destination directory already exist! Type not exist directory");
            }
        }
    }
    public static void CopyDir(string source, string dest)
    {
        DirectoryInfo dir = new DirectoryInfo(source);
        if (!dir.Exists)
        {
            Console.WriteLine("Source directory does not exist: ");
        }
        DirectoryInfo[] dirs = dir.GetDirectories();
        if (!Directory.Exists(dest))
        {
            Directory.CreateDirectory(dest);
        }
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            string path = Path.Combine(dest, file.Name);
            file.CopyTo(path, false);
        }
        foreach (DirectoryInfo subdir in dirs)
        {
            string path = Path.Combine(dest, subdir.Name);
            CopyDir(subdir.FullName, path);
        }
    }
}