using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CombatantSingleton {

    //use this to transfer data fromt he overworld to the combat scene
    /*
    For example:
        Characters and their information
        inventory
        special conditions
    Singleton's maintain a single instance so that the data will be consistent no matter where you get
    it from
    */
    public List<Combatant> combatants { get; set; } //set this before going into combatants get it when loading combat scene.
    private static CombatantSingleton instance = null;
    private CombatantSingleton()
    {
    
    }
    static public CombatantSingleton getInstance()
    {
        if(instance == null)
        {
            instance = new CombatantSingleton();
        }
        return instance;
    }
}
