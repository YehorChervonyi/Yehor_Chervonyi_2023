using task1;

string userInputPath = "";
await WorkingWithFileSystem.GetDrivesAsync();
while (true)
{
    userInputPath = await WorkingWithFileSystem.GetDirAsync();
    if (userInputPath == "m")
    {
        await Menu.CmenuAsync();
    }
    if (userInputPath == "d")
    {
        await WorkingWithFileSystem.GetDrivesAsync();
    }
    else
    {
        await WorkingWithFileSystem.CdAsync(userInputPath, Directory.GetCurrentDirectory());
        await WorkingWithFileSystem.GetDirectoryFilesAsync(Directory.GetCurrentDirectory());
    }
}