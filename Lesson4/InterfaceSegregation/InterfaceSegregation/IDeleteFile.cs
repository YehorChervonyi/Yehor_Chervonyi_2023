namespace LiskovSubstitution;

public interface DeleteFile : ICheckRole
{
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