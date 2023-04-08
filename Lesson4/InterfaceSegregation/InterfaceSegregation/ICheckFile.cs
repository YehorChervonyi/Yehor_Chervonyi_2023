namespace LiskovSubstitution;

public interface ICheckFile : ICheckRole
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
}