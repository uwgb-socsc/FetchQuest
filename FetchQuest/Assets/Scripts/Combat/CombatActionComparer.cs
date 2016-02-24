using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class CombatActionComparer : IComparer<CombatAction> {
    public int Compare(CombatAction x, CombatAction y)
    {
        //return (int)(x.agility - y.agility);
        return (int)(x.initiator.agility - y.initiator.agility);
    }

    
}
