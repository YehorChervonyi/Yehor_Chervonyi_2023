namespace LiskovSubstitution;

public interface IReadFromFile : ICheckRole
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
}