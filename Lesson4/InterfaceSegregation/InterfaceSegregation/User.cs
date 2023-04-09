namespace LiskovSubstitution;

public class User : IWorkingWithFile
{
    public string? ReadFromFile(string filename)
    {
        return ""; //Some text from file
    }

    public void WriteToFile(string filename)
    { 
        // Give access to write to file
    }

    public void DeleteFile(string filename)
    {
        // Give access to delete file
    }

    public void DownloadFile(string filename)
    {
        // Give access to download file
    }

    public void CopyFile(string filename)
    {
        // Give access to copy file
    }

    public void GetDataFromFile(string filename)
    {
        // Give access to get data from file
    }

    public void CheckFile(string filename)
    { 
        // Give access to check file
    }

    public void SaveToFile(string filename)
    {
        // Give access to svae data to file
    }
}