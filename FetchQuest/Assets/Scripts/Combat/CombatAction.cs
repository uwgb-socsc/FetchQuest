using UnityEngine;
using System.Collections;

public class CombatAction {

    public enum ActionType { attack, item }
    public ActionType selectedType { get; set; }
    public Attack attack { get; set; }
    public Item item { get; set; }
    public Combatant target { get; set; }
    public Combatant initiator { get; set; }

}
