namespace LiskovSubstitution;

public interface IWorkingWithUsers
{
    public Guid? CheckRole(Guid role);
    public Guid? CheckUser(Guid user);
}