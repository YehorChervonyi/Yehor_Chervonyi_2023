namespace LiskovSubstitution;

public interface IWriteToFile : ICheckRole
{
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
}