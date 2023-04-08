namespace LiskovSubstitution;

public interface ICheckUser
{
    public Guid? CheckUser(Guid user)
    {
        // if user in db
        return user;
        //else
        return null;
    }
}