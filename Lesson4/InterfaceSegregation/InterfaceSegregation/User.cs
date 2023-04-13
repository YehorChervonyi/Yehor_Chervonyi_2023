using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution;

public class User : CheckingRole, IUser
{
    public string? ReadFromFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            return ""; //Some text from file
        }
        else
        {
            // Return error about wrong role
            return null;
        }
    }

    public void WriteToFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to write to file
        }
        else
        {
            // Return error about wrong role
        }
    }
    
    public void DownloadFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to download file
        }
        else
        {
            // Return error about wrong role
        }
    }
}