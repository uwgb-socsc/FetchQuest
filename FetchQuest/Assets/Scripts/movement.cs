using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	private Rigidbody rb;
	public float moveSpeed = .75f;
	public float turnSpeed = 5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		float turnHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
		transform.Translate (0.0f, 0.0f, moveVertical * moveSpeed, Space.Self);
		transform.Rotate (0.0f, turnHorizontal * turnSpeed, 0.0f);
		if ((transform.rotation.eulerAngles.x != 0.0f) ||(transform.rotation.eulerAngles.x != 0.0f)) {
			transform.eulerAngles = new Vector3(0.0f, transform.rotation.eulerAngles.y, 0.0f);
		}
	}
}
