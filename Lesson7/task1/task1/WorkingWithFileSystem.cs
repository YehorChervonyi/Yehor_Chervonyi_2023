namespace task1;

public class WorkingWithFileSystem
{
    public static async Task GetDirectoryFilesAsync(string path)
    {
        var current = new DirectoryInfo(path);
        var files = await Task.Run(() => Directory.GetFiles(current.FullName));
        var dirs = await  Task.Run(() => Directory.GetDirectories(current.FullName));
        Console.WriteLine("------------| Name |------------+" +
                          "---------| Change date |--------+" +
                          "-----| Type |-----+" +
                          "----| Creation time |-----");
        foreach (var dir in dirs)
        {
            Console.WriteLine(String.Format("| {0,-30}|\t{1,-25}|\t{2,-12}|\t{3,-22}|", dir.Split('\\').Last()+@"\", Directory.GetLastWriteTime(dir), "Folder" , Directory.GetCreationTime(dir)));
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
    public static Task GetDrivesAsync()
    {
        return Task.Run(() =>
        {
            var drives = DriveInfo.GetDrives();
            Console.WriteLine(" --| Drives |-- ");
            foreach (var drive in drives)
            {
                Console.WriteLine($"|     {drive.Name}     |");
            }

            Console.WriteLine(" ------------- ");
        });
    }
    
    public static async Task CdAsync(string? name, string current)
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
            await Task.Run((() => Directory.SetCurrentDirectory(dir)));
        }
    }
    
    public static async Task<string> GetDirAsync()
    {
        Console.Write($"${Directory.GetCurrentDirectory()}>");
        string input = await Task.Run(() => Console.ReadLine());
        return input;
    }

    
}