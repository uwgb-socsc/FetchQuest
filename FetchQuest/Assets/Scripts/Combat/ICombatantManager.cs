using UnityEngine;
using System.Collections;

public interface ICombatantManager  {

    Attack.Special choose();
    Attack Achoice();
    Combatant TargetChoice();
    Item Ichoice();
    double getTurnDecider();
}
