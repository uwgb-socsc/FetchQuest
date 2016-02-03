using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    string name { get; set; } //warning here would be solved by not inheriting from MonoBehaviour
    string description { get; set; }
    double power { get; set; }
    public enum Special {spec1, spec2, spec3, spec4, spec5, spec6 }; //these are special effects rename them later. SERIOUSLY DO NOT LEAVE THEM THIS WAY WHEN WE DECIDE!

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
