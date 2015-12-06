using UnityEngine;
using System.Collections;

public class elevator : MonoBehaviour {
    public GameObject ball;
    public float dropSpeed = 1f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent < Rigidbody > ();
	}
	
	// Update is called once per frame
	void Update () {
	    if(ball.transform.position.y <= 15.5)
        {
            transform.position = new Vector3(0.0f, 23.75f, 0.0f);
            ball.transform.position = new Vector3(0.0f, 24.5f, 0.0f);
        }

        rb.velocity = new Vector3 (0.0f, dropSpeed, 0.0f);
	}
}
