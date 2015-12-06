using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
    public float rotateSpeed = 4f;
    private float spin = 0f;
	
	// Update is called once per frame
	void Update () {
        spin++;
        transform.eulerAngles = new Vector3(0.0f, transform.rotation.y + (spin * rotateSpeed), 0.0f);
	}
}
