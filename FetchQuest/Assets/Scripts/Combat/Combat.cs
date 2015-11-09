using UnityEngine;
using System.Collections;



public class Combat : MonoBehaviour {
    /*
    This class is what makes the Combat actually work.
    It will put everyone fighting into a list (ordered by who goes first in a turn)
    Then it calls some kind of option choosing class (either asking the player for input or an AI) 
    Yes that means this calls for an interface!

    */
    // List of combatants ordered by turn order
    // two more lists of allies and enemies. 

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void RunCombat()
    {
        //while(combatStillGoingOn)
        /*
            turnNum++;
            foreach something in turnOrderList
                choiceType = something.choose(array/list of enemies)
                if choiceType == attack
                    Achoice = something.Achoice()
                    target = something.chooseTarget(); The target is an actual combatant so just calculate damage and do it
                    CalcDamage()
                    target.takeDamage()
                if choiceType == item
                    Ichoice = something.Ichoice()
                    UseItem(Ichoice)

        */
       
        
    }
    double CalcDamage(Combatant attacker, Combatant defender, Attack attack)
    {
        throw new System.NotImplementedException();
    }
}
