namespace LiskovSubstitution;

public interface ISaveToFile : ICheckRole
{
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
}