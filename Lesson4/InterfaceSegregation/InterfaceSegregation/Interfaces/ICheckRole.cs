namespace LiskovSubstitution.Interfaces;

public interface ICheckRole
{
    public Guid? CheckRole(Guid role);
    public Guid? CheckUser(Guid user);
}