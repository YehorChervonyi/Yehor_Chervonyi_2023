using System.Text;

namespace task1;

public static class WorkingWithFiles
{
    public static string ReadFile(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        Console.WriteLine(path);
        if (File.Exists(path))
        {
            using (FileStream readfilestream = File.OpenRead(path))
            {
                var bytes = new byte[readfilestream.Length];
                readfilestream.Read(bytes, 0, bytes.Length);
                return Encoding.Default.GetString(bytes);
            }
        }
        else
        {
            return "File does not exist";
        }
    }

    public static void RemoveFile(string path)
    {
        path = Path.Combine(Directory.GetCurrentDirectory(), path);
        if (File.Exists(path))
        {
            File.Delete(path);    
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public static void MoveFile (string from, string to)
    {
        from = Path.Combine(Directory.GetCurrentDirectory(), from);
        if (File.Exists(from))
        {
            if (!File.Exists(to))
            {
                File.Move(from,to);
                Console.WriteLine("Moved");
            }
        }

    }
    
}