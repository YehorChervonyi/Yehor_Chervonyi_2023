using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution;

public class Administrator : User , IAdministrator
{
    public void CheckFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to check file
        }
        else
        {
            // Return error about wrong role
        }
    }
    public void SaveToFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to svae data to file
        }
        else
        {
            // Return error about wrong role
        }
    }
    public void CopyFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to copy file
        }
        else
        {
            // Return error about wrong role
        }
    }
    public void DeleteFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to delete file
        }
        else
        {
            // Return error about wrong role
        }
    }

}