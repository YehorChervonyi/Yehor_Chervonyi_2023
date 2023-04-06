namespace task1;

public class WorkingWithFileSystem
{
    public static void GetDirectoryFiles(string path)
    {
        var current = new DirectoryInfo(path);
        var files = Directory.GetFiles(current.FullName);
        var dirs = Directory.GetDirectories(current.FullName);
        Console.WriteLine("------------| Name |------------+" +
                          "---------| Change date |--------+" +
                          "-----| Type |-----+" +
                          "----| Creation time |-----");
        foreach (var dir in dirs)
        {
            Console.WriteLine(String.Format("| {0,-30}|\t{1,-25}|\t{2,-12}|\t{3,-22}|", dir.Split('\\').Last()+"/", Directory.GetLastWriteTime(dir), "Folder" , Directory.GetCreationTime(dir)));
        }
        foreach (var file in files)
        {
            // Console.WriteLine($"|{file.Split('\\').Last()}|\t");
            Console.WriteLine(String.Format("| {0,-30}|\t{1,-25}|\t{2,-12}|\t{3,-22}|", file.Split('\\').Last(), Directory.GetLastWriteTime(file), "File" , Directory.GetCreationTime(file)));
        }
        Console.WriteLine("--------------------------------+" +
                          "--------------------------------+" +
                          "------------------+" +              
                          "--------------------------\n" +
                          "| m - menu | d - show all drives |");       
    }
    public static void GetDrives()
    {
        var drives = DriveInfo.GetDrives();
        Console.WriteLine(" --| Drives |-- ");
        foreach (var drive in drives)
        {
            Console.WriteLine($"|     {drive.Name}     |");
        }
        Console.WriteLine(" ------------- ");
    }
    
    public static void Cd(string? name, string current)
    {
        if (name == "../")
        {
            var info = new DirectoryInfo(Directory.GetCurrentDirectory());
            var parent = info.Parent;
            if (parent != null)
            {
                Directory.SetCurrentDirectory(parent.FullName);
            }
            else
            {
                Directory.SetCurrentDirectory(current);
            }
        }
        var dir = Path.Combine(current, name);
        if (Directory.Exists(dir))
        {
            Directory.SetCurrentDirectory(dir);
        }
    }
    
    public static string GetDir()
    {
        Console.Write($"${Directory.GetCurrentDirectory()}>");
        string input = Console.ReadLine();
        return input;
    }

    
}