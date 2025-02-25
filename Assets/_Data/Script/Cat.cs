using UnityEngine;

public class Cat : FourLeg
{
    public override string GetName()
    {
        return "Kitty";
    }

    public override string MakeSound()
    {
        string sound = "meo meo";
        return sound;
    }

    void CatchMouse()
    {
       
    }
}
