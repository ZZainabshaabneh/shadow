using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{

    Soldier soldier = new Soldier();
    Officer officer = new("Hala", 90, new Position(23, 10, 0));

    Character[] characters = new Character[2];
    void Start()
    {
        characters[0] = soldier;
        characters[1] = officer;
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].DisplayInfo();
        }
        Debug.Log("Before Attack--> Soldier Health: " + soldier.Health);
        officer.Attack(20, soldier);
        Debug.Log("After Attack--> Soldier Health: " + soldier.Health);


    }

}
