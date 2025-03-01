using UnityEngine;

public class Dog : FourLeg
{
    public override string GetName()
    {
        return "Doggy";
    }

    public override string MakeSound()
    {
        string sound = "gau gau";
        return sound;
    }
    void GuarHouse()
    {
        
    }
}
