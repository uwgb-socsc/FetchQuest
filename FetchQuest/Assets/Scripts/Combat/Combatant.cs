using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Combatant : MonoBehaviour {

    // Use this for initialization
    /*
    Charisma
    Stamina
    Intelligence
    Perception
    Agility
    Luck
    Tool Use*
    Dexterity
    Defense
    Strength
    */
    ICombatantManager manager;
    public double charisma { get; set; }
    public double stamina { get; set; }
    public double intelligence { get; set; }
    public double perception { get; set; }
    public double agility { get; set; }
    public double luck { get; set; }
    public double toolUse { get; set; }
    public double dexterity { get; set; }
    public double defense { get; set; }
    public double strength { get; set; }

    public double hp { get; set; }

    public bool isAlive { get; set; }
    public bool canAttack { get; set; }
    public bool canItem { get; set; }
    public bool canRun { get; set; }

    List<Item> inventory;
    Equipment slot1;
    Equipment slot2;
    Equipment slot3;
    Equipment slot4;
    Equipment slot5;
    Equipment weaponSlot;
    //

    //a list for attacks
    //a list for items. 
    
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void TakeDamage(double damage)
    {
        hp -= damage;
    }
}
