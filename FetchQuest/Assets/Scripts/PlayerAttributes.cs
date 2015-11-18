using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour {

    public enum Breeds { Chihuahua, Collie, Husky, Retriever, StBernard, Terrier};
    public Breeds playerBreed = Breeds.Retriever;

    public double charisma = 20;
    public double stamina = 20;
    public double intelligence = 20;
    public double perception = 20;
    public double agility = 20;
    public double luck = 20;
    public double toolUse = 20;
    public double dexterity = 20;
    public double defense = 20;
    public double strength = 20;

    private double currentStamina;

    private System.Random gen = new System.Random();

    // Use this for initialization
    void Start () {
        switch (playerBreed)
        {
            case Breeds.Chihuahua:
                luck += 16;
                stamina += 8;
                strength -= 8;
                break;
            case Breeds.Collie:
                intelligence += 16;
                toolUse += 8;
                charisma -= 8;
                break;
            case Breeds.Husky:
                charisma += 16;
                intelligence += 8;
                luck -= 8;
                break;
            case Breeds.Retriever:
                perception += 16;
                dexterity += 8;
                intelligence -= 8;
                break;
            case Breeds.StBernard:
                strength += 16;
                defense += 8;
                agility -= 8;
                break;
            case Breeds.Terrier:
                agility += 16;
                dexterity += 8;
                defense -= 8;
                break;
            default:
                break;
        }
        currentStamina = stamina;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
