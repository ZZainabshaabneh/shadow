using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{


    public class Soldier : Character
    {

        
        public Soldier() : base() {
            base.DisplayInfo();
            DisplayInfo();
        }
        public Soldier(string Name, int health, Position position) : base(Name, health, position)
        {
            this.Name = Name;
            this.Health = health;
            this.position = position;
        }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();

        }
        void Start()
        {

        }

    }
}