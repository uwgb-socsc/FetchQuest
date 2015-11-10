using UnityEngine;
using System.Collections;

public interface ICombatantManager  {

    Combat.choices choose();
    Attack Achoice();
    Combatant TargetChoice();
    Item Ichoice();
    double getTurnDecider();
}
