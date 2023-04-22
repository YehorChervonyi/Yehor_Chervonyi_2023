namespace task1;

public static class WorkingWithDirs
{
    public static async Task RemoveDirAsync(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        if (Directory.Exists(path))
        {
            await Task.Run(() => Directory.Delete(path,true));
        }
        else
        {
            Console.WriteLine("Directory does not exist");
        }
    }
    public static async Task MoveDirAsync(string what, string to)
    {
        what = Path.Combine(Directory.GetCurrentDirectory(), what);
        if (Directory.Exists(what))
        {
            if (Directory.Exists(to))
            {
                await Task.Run(() =>
                {
                    var dest = Path.Combine(to, what.Split("\\")[^2]);
                    Console.WriteLine(dest);
                    Directory.Move(what, dest);
                });
            }
            else
            {
                Console.WriteLine("Destination directory already exist! Type not exist directory");
            }
        }
    }
    public static async Task CopyDirAsync(string source, string dest)
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
            await Task.Run(() => file.CopyTo(path, false));
        }
        foreach (DirectoryInfo subdir in dirs)
        {
            string path = Path.Combine(dest, subdir.Name);
            await CopyDirAsync(subdir.FullName, path);
        }
    }
}