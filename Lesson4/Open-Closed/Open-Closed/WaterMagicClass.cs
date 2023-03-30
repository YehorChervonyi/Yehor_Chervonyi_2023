namespace Open_Closed;

public class WaterMagicClass:MagicClass
{
    public override string CountYourMagic()
    {
        string baseMagicCount = base.CountYourMagic();
        if (magic == 50000000)
        {
            return "Incredible! You have 50 millions of power! It's water magic!\n" + baseMagicCount;
        }
        else
        {
            return baseMagicCount;
        }
    }
}