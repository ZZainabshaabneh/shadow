using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{


  public class Officer : Character
  {
    private int health;
    public Officer(string Name, int health, Position position) : base(Name, health, position)
    {
      this.Name = Name;
      this.health = health;
      this.position = position;
    }


    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Debug.Log("Officer");
    }
    void Start()
    {

    }

  }
}
