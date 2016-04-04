using UnityEngine;
using System.Collections.Generic;

public interface ICombatantManager  {

    void setup(List<Combatant> participants);
    CombatAction getAction();
    bool hasAction();
}
