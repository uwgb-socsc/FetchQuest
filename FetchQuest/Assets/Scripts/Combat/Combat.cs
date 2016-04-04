using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Combat : MonoBehaviour {
    /*
    This class is what makes the Combat actually work.
    It will put everyone fighting into a list (ordered by who goes first in a turn)
    Then it calls some kind of option choosing class (either asking the player for input or an AI) 
    Yes that means this calls for an interface!

    */
    // List of combatants ordered by turn order
    // two more lists of allies and enemies. 
    private ICombatantManager[] combatantManagers; //this my be switched to combatant instead. We'll see.
    private List<ICombatantManager> listOfCombatantManagers;
    public enum choices { attack, item, run };
    public int turnNum;
    public List<CombatAction> actionQueue;
    private Combatant[] combatants;
    private List<Combatant> listOfCombatants;
    private int turnState;

	// Use this for initialization
	void Start () {
        actionQueue = new List<CombatAction>();
        combatants = GetComponentsInChildren<Combatant>();
        listOfCombatants = new List<Combatant>();
        listOfCombatants.Sort(new CombatantComparer());
        //assumes combatantManagers are attached. Could be changed for combatants 
        //combatantManagers = GetComponentsInChildren<ICombatantManager>();
        //listOfCombatantManagers = new List<ICombatantManager>(combatantManagers);
       // listOfCombatantManagers.Sort(new CombatantComparer());
	}
	
	// Update is called once per frame
	void Update () {
        //call RunCombatTurn todo a turn
        /*
        if(conditionsToRunATurn == true)
        {
            RunCombatTurn();
        }
        */
        RunCombatTurn();
	}
    void RunCombatTurn()
    {
        //All combatants decide what they are doing.
        //AI picks what they will do.
        //ask player what they will do.
        //throw those choices into a priority queue 
        //Go through each to handle the graphical aspect of the combat,
        //and apply the effects like damage, healing, or whatever else there is.  
        /*
        turnState
            0 nothing done, run setups
            1 waiting to get all actions
            2 wait for actions to be run
            reset to 0 when all actions have been run.
        */
        if (turnState == 0)
        {
            foreach (Combatant c in listOfCombatants)
            {
                c.manager.setup(listOfCombatants);
            }
            turnState = 1;
        }else if(turnState == 1)
        {
            if (actionQueue.Count <= listOfCombatants.Count)
            {
                foreach(Combatant c in listOfCombatants)
                {
                    if(c.manager.hasAction())
                    {
                        actionQueue.Add(c.manager.getAction());
                    }
                }
            }
            if(actionQueue.Count == listOfCombatants.Count)
            {
                turnState = 2;
            }
            if(actionQueue.Count > listOfCombatants.Count)
            {
                Console.Write("CombatantManagers should not have actions after they give out an action");

            }
        }
        if(turnState == 2)
        {
            //needs to flag whatever handles the animations and effects to do their thing so it can run the turn.
            //there needs to be some kind of action executor script
        }
        
        actionQueue.Sort();
        //Below is old psuedocode. I have a different plan now.
        //while(combatStillGoingOn)
        /*
            turnNum++;
            foreach something in turnOrderList
                choiceType = something.choose(array/list of enemies)
                if choiceType == attack
                    Achoice = something.Achoice()
                    target = something.chooseTarget(Achoice); The target is an actual combatant so just calculate damage and do it
                    CalcDamage()
                    target.takeDamage()
                if choiceType == item
                    Ichoice = something.Ichoice()
                    something.chooseTarget(Ichoice)
                    UseItem(Ichoice)

        */
       
        
    }
    double CalcDamage(Combatant attacker, Combatant defender, Attack attack)
    {
        System.Random gen = new System.Random();
        double crit = 1.0;
        double attackPower = 0.0;
        double defensePower = 0.0;
        
        //does hit
        if(gen.NextDouble() * 100 > (attack.accuracy + attacker.perception))
        {
            return 0.0;
        }
        //is crit
       
        if(gen.NextDouble()*100 < (0.05+0.02 * attacker.luck))
        {
            crit = 1.5;        
        }
        //do damage
        attackPower = attack.power * attacker.strength;
        defensePower = defender.defense + defender.getArmorValue();

        //return
        
        return (attackPower / defensePower) * crit;
    }
}
