using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	private Rigidbody rb;
	public float moveSpeed = .3f;
	public float turnSpeed = 5f;
	public float jumpHeight = 8f;

	private bool isGrounded = true;

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
		if ((transform.rotation.eulerAngles.x != 0.0f) || (transform.rotation.eulerAngles.x != 0.0f)) {
			transform.eulerAngles = new Vector3 (0.0f, transform.rotation.eulerAngles.y, 0.0f);
		}
		if (Input.GetButton ("Jump") && isGrounded) {
			isGrounded = false;
			rb.velocity = new Vector3(0.0f, jumpHeight, 0.0f);
		}
	}

	void OnCollisionEnter(Collision floor){
		if (floor.collider.tag == "Floor") {
			isGrounded = true;
		}
	}
}
