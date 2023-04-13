using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution;

public class Owner : Administrator ,IOwner
{
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
}