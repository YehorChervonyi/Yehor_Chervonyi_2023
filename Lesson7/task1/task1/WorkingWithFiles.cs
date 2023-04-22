using System.Text;

namespace task1;

public static class WorkingWithFiles
{
    public static async Task<string> ReadFileAsync(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        Console.WriteLine(path);
        if (File.Exists(path))
        {
            using (FileStream readfilestream = File.OpenRead(path))
            {
                var bytes = new byte[readfilestream.Length];
                await readfilestream.ReadAsync(bytes, 0, bytes.Length);
                return Encoding.Default.GetString(bytes);
            }
        }
        else
        {
            return "File does not exist";
        }
    }

    public static async Task RemoveFileAsync(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        if (File.Exists(path))
        {
            await Task.Run(() => File.Delete(path));    
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public static async Task MoveFileAsync (string from, string to)
    {
        from = Path.Combine(Directory.GetCurrentDirectory(), from);
        if (File.Exists(from))
        {
            if (!File.Exists(to))
            {
                await Task.Run(() => File.Move(from,to));
                Console.WriteLine("Moved");
            }
        }

    }
    
}