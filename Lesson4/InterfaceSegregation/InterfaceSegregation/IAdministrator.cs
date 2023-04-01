namespace LiskovSubstitution;

public interface IAdministrator : IWorkingWithFile
{
    public string ReadFromFile(string filename);
    public void WriteToFile(string filename);
    public void DeleteFile(string filename);
    public void DownloadFile(string filename);
    public void CopyFile(string filename);
    public void GetDataFromFile(string filename);
    public void CheckFile(string filename);
    public void SaveToFile(string filename);
}