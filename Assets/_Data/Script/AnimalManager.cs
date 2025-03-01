using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    protected List<FourLeg> fourLegs = new();

    private void Start()
    {
        this.AddAnimalToList();
        this.MakeAnimalsDoSomething();

    }


    protected void MakeAnimalsDoSomething()
    {
        foreach (FourLeg fourLeg in this.fourLegs)
        {
            this.MakeAnimalDoSomething(fourLeg);
        }
    }

    protected void MakeAnimalDoSomething(FourLeg fourLeg)
    {
        string name = fourLeg.GetName();
        string sound = fourLeg.MakeSound();
        Debug.Log(name + ": " + sound);
        string fur = fourLeg.IsHasFur();
        Debug.Log("Has fur: " + fur);
    }

    protected void AddAnimalToList()
    {
        Dog dog = new();
        this.fourLegs.Add(dog);

        Dog dog2 = new();
        this.fourLegs.Add(dog2);

        Cat cat = new();
        this.fourLegs.Add(cat);

        Pig pig = new();
        this.fourLegs.Add(pig);

        Pig pig2 = new();
        this.fourLegs.Add(pig2);
    }

    void Update()
    {

    }

}
