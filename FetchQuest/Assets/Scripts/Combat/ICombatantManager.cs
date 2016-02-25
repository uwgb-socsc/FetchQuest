using UnityEngine;
using System.Collections.Generic;

public interface ICombatantManager  {

    CombatAction getAction(List<Combatant> participants);
}
