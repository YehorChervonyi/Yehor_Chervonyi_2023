namespace LiskovSubstitution.Interfaces;

public interface IAdministrator
{
    public void CheckFile(string filename);
    public void SaveToFile(string filename);
    public void CopyFile(string filename);
    public void DeleteFile(string filename);
}