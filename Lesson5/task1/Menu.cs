namespace task1;

public class Menu
{
    public static void Cmenu()
    {
        Console.Write(" ---------| Menu |-----------\n" +
                      "|  r  | Read file            |\n" +
                      "|  rm | Remove file/dir      |\n" +
                      "|  m  | Move file/dir        |\n" +
                      "|  c  | Copy file/dir        |\n" +
                      "|  i  | Info                 |\n" +
                      "|  q  | Quit                 |\n" +
                      " ----------------------------\n" +
                      "Action: ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "r":
                Console.Write("File name for read: ");
                input = Console.ReadLine();
                Console.WriteLine(WorkingWithFiles.ReadFile(input));
                break;
            case "rm":
                Console.Write("File/Dir name to delete: ");
                input = Console.ReadLine();
                if (input[^1..] == "/" || input[^1..] == @"\")
                {
                    WorkingWithDirs.RemoveDir(input);    
                }
                else
                {
                    WorkingWithFiles.RemoveFile(input);
                }
                break;
            case "m":
                Console.Write("File/Dir name to move: ");
                input = Console.ReadLine();
                if (input[^1..] == "/" || input[^1..] == @"\")
                {
                    string name = input;
                    Console.Write("Destination directory: ");
                    input = Console.ReadLine();
                    WorkingWithDirs.MoveDir(name, input);
                }
                else
                {
                    string name = input;
                    Console.Write("Destination directory: ");
                    input = Console.ReadLine();
                    WorkingWithFiles.MoveFile(name, Path.Combine(input, name));
                }
                break;
            case "c":
                Console.Write("File/Dir name to move: ");
                input = Console.ReadLine();
                if (input[^1..] == "/" || input[^1..] == @"\")
                {
                    string name = input;
                    Console.Write("Destination directory: ");
                    input = Console.ReadLine();
                    WorkingWithDirs.CopyDir(Path.Combine(Directory.GetCurrentDirectory(), name), input);    
                }
                else
                {
                    string name = input;
                    Console.Write("Destination directory: ");
                    input = Console.ReadLine();
                    File.Copy(Path.Combine(Directory.GetCurrentDirectory(), name), input);
                }
                break;
            case "i":
                Console.Write("File/Dir name to get info: ");
                input = Console.ReadLine();
                if (input[^1..] == "/" || input[^1..] == @"\")
                {
                    var info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), input));
                    Console.WriteLine($"-----Directory Info-----\n" +
                                      $"Name: {info.Name}\n" +
                                      $"Parent: {info.Parent}\n" +
                                      $"Extension: Folder\n" +
                                      $"Creation time: {info.CreationTime}\n" +
                                      $"Last write time: {info.LastWriteTime}\n");
                }
                else
                {
                    var info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), input));
                    Console.WriteLine($"-----File Info-----\n" +
                                      $"Name: {info.Name}\n" +
                                      $"Parent: {info.Parent}\n" +
                                      $"Extension: {info.Extension}\n" +
                                      $"Creation time: {info.CreationTime}\n" +
                                      $"Last write time: {info.LastWriteTime}\n");
                }
                break;
        }
    }
}