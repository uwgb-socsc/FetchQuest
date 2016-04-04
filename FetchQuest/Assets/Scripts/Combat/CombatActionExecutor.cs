using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CombatActionExecutor : MonoBehaviour {

    // Use this for initialization
    List<CombatAction> actions;
    int index; //tells what action is currently being exectued
    bool doneWithIndex; //tells if the action is done being executed (so it moves on to the next one)
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setActionList(List<CombatAction> actions)
    {
        this.actions = actions;
    }
}
