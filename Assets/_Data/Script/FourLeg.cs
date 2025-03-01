using UnityEngine;

public abstract class FourLeg
{
    string petName = "#noName";
    string petSound = "#noName";
    int legCount = 4;
    int tailCount = 1;

    public abstract string GetName();
    public abstract string MakeSound();

    private void Start()
    {
        /*this.petName = this.GetName();
        this.petSound = this.MakeSound();
        Debug.Log(this.petName + ": " + this.petSound);
        Debug.Log("Has fur: " + this.IsHasFur());*/

    }

    public virtual string IsHasFur()
    {
        return "Yes";
    }
    
}
