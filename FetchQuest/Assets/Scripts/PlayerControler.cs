using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public float speed;
	public Text countText;
	public Text winText;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVeritical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVeritical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)	
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!";
		}
	}
}