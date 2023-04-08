namespace LiskovSubstitution;

public interface IDownloadFile : ICheckRole
{
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