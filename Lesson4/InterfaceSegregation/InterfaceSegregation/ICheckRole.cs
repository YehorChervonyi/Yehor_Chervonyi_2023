namespace LiskovSubstitution;

public interface ICheckRole : ICheckUser
{
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