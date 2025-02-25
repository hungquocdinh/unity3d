using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    string name =  "No Name"; //Tên nhân vật
    int hp = 100;//Hp nhân vật
    float weigh = 7.4f;
    float runSpeed = 15f;

    string GetCharacterName()
    {
        string newName = "Tôi là Hưng";
        Debug.Log("GetCharacterName");
        return newName;

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
        this.name = this.GetCharacterName();
        Debug.Log(this.name);
        this.Running();
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Update");
        this.GetCharacterName();
    }

    void Running()
    {
        Debug.Log(this.runSpeed);
    }

    void Jumping()
    {
        Debug.Log("Jumping");
    }
}
