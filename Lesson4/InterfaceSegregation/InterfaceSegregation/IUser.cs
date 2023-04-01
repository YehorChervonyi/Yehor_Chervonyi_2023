namespace LiskovSubstitution;

public interface IUser : IWorkingWithFile
{
    public string ReadFromFile(string filename);
    public void WriteToFile(string filename);
    public void DownloadFile(string filename);
    public void CopyFile(string filename);
    public void CheckFile(string filename);
}