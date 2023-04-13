namespace LiskovSubstitution.Interfaces;

public interface IUser
{
    public string? ReadFromFile(string filename);
    public void WriteToFile(string filename);
    public void DownloadFile(string filename);
}