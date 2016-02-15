using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    void Awake()
    {
        if (tag!="Player")
        {
            tag = "Player";
            Debug.LogWarning("PlayerMove script assigned to object without the tag 'Player', tag has been assigned automatically", transform);
        }
    }

	// Use this for initialization
	void Start () {
        //Obtain the stats that are displayed on screen
        GUIText[] stats = FindObjectsOfType<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
