using task1;

string userInputPath = "";
WorkingWithFileSystem.GetDrives();
while (true)
{
    userInputPath = WorkingWithFileSystem.GetDir();
    if (userInputPath == "m")
    {
        Menu.Cmenu();
    }
    if (userInputPath == "d")
    {
        WorkingWithFileSystem.GetDrives();
    }
    else
    {
        WorkingWithFileSystem.Cd(userInputPath, Directory.GetCurrentDirectory());
        WorkingWithFileSystem.GetDirectoryFiles(Directory.GetCurrentDirectory());
    }
}