namespace LiskovSubstitution;

public class User : IWorkingWithFile
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

    public void GetDataFromFile(string filename)
    {
        var role = CheckRole(Guid.Empty);
        if (role != null)
        {
            // Give access to get data from file
        }
        else
        {
            // Return error about wrong role
        }
    }

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
    
    public Guid? CheckUser(Guid user)
    {
        // if user in db
        return user;
        //else
        return null;
    }

    public Guid? CheckRole(Guid role)
    {
        var user = CheckUser(Guid.Empty);
        if (user != null)
        {
            return role;
        }
        else
        {
            return null;
        }
    }
}