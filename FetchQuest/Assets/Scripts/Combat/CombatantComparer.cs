using UnityEngine;
using System.Collections.Generic;
using System;

public class CombatantComparer : IComparer<Combatant>
{
    public int Compare(Combatant x, Combatant y)
    {
        return (int) (x.agility - y.agility);
    }

    //public int Compare(ICombatantManager x, ICombatantManager y)
    //{
     //   return (int) (x.getTurnDecider() - y.getTurnDecider()); //have to cast we'll do a proper round or just add/subtract 1 to make sure even the smallest difference is detected should we decide to.

    //}

    // Use this for initialization
    
}
