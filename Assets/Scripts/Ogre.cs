using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Ogre : Enemy
    {
        void Start()
        {
            Energy = 15;
            MaxEnergy = 15;
            Attack = 7;
            Defence = 5;
            Gold = 30;
            Description = "Ogre";
            Inventory.Add("Tooth");
        }
    }
}
