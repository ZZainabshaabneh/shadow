using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
using UnityEngine.UIElements;
namespace Assignment18
{
    public class Character
    {
        public string Name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100)
                    health = 100;
                else
                    if (value < 0)
                {
                    health = 0;
                }
                else health = value;
            }
        }
        public Character(string Name, int health, Position position)
        {
            this.Name = Name;
            this.health = health;
            this.position = position;
        }
        public Character() : this("Nm Name", 100, new Position(0, 0, 0)) { }
        public virtual void DisplayInfo()
        {
            Debug.Log(Name);
            Debug.Log(health);
            position.printPostion();
        }
        public void Attack(int damge, Character target)
        {
            target.health -= damge;
        }
        public void Attack(int damge, Character target, string attackType = "shooting")
        {
            Attack(damge, target);
            Debug.Log(attackType);
        }
        void Start()
        {

        }

    }
}