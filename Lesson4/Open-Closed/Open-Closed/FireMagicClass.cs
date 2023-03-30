namespace Open_Closed;

public class FireMagicClass:MagicClass
{
    public override string CountYourMagic()
    {
        string baseMagicCount = base.CountYourMagic();
        if (magic == 150)
        {
            return "Wow, your magic is fire magic!\n" + baseMagicCount;
        }
        else
        {
            return baseMagicCount;
        }
    }
}