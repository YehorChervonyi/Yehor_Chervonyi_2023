namespace LiskovSubstitution;

public class Administrator : User , IWorkingWithUsers
{
    public Guid? CheckUser(Guid user)
    {
        // if user in db
        return user;
        //else
        return null;
    }

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