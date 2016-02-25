using UnityEngine;
using System.Collections;

public class Consumable : Item {


    public enum ConsumeType {healthPotion, staminaPotion, type3 } //determines what kind of an effect a consumable could have
    double NumValue; //this indicates the 'power of a consumable item. 
    public ConsumeType type; 
	
	
}
