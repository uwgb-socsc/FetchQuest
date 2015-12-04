using UnityEngine;
using System.Collections;

public class playerSpawner : MonoBehaviour
{
    public string characterClass;
    public GameObject small;
    public GameObject smallMed;
    public GameObject medium;
    public GameObject medLarge;
    public GameObject large;
    public Transform[] playerSpawn;

    // Use this for initialization
    void Start()
    {
        int spawnPointIndex = Random.Range(0, playerSpawn.Length);

        switch (characterClass)
        {
            case "small":
                Instantiate(small, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
            case "smallMed":
                Instantiate(smallMed, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
            case "medium":
                Instantiate(medium, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
            case "medLarge":
                Instantiate(medLarge, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
            case "large":
                Instantiate(large, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
            default:
                Instantiate(medium, playerSpawn[spawnPointIndex].position, playerSpawn[spawnPointIndex].rotation);
                break;
        }
    }
}
	
	// Update is called once per frame
/*	void Update () {
	
	}
}*/
