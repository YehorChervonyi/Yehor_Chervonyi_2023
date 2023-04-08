namespace LiskovSubstitution;

public interface ICopyFile : ICheckRole
{
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
}