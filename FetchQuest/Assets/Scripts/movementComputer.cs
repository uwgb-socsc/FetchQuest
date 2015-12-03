using UnityEngine;
using System.Collections;

public class movementComputer : MonoBehaviour {
    private Rigidbody rb;
    private bool isGrounded = true;
    //    private bool isLocked = true;
    private float mouseX;
    private float mouseY;

    public float jumpHeight = 8f;
    public float moveSpeed = .3f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
/*        if (isLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }*/

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        mouseX = (Input.mousePosition.x - Screen.width / 2) / 2;
        mouseY = -(Input.mousePosition.y - Screen.height / 2) / 2;

        transform.Translate(moveHorizontal * moveSpeed, 0.0f, moveVertical * moveSpeed, Space.Self);

        if ((transform.rotation.x != 0.0f) || (transform.rotation.z != 0.0f))
        {
            transform.eulerAngles = new Vector3(0.0f, transform.rotation.y, 0.0f);
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            isGrounded = false;
            rb.velocity = new Vector3(0.0f, jumpHeight, 0.0f);
        }

        if (mouseX <= -180)
        {
            mouseX += 360;
        }
        else if (mouseX > 180)
        {
            mouseX -= 360;
        }
        transform.eulerAngles = new Vector3(0.0f, mouseX, 0.0f);
        if (mouseY > 70) 
        {
            mouseY = 70;
        }
        else if (mouseY < -90)
        {
            mouseY = -90;
        }
        Camera.main.transform.eulerAngles = new Vector3(mouseY, mouseX, 0.0f);

        /*        if(Input.GetKeyDown(KeyCode.Escape))
                {
                    isLocked = false;
                }
                else if(Input.GetKeyDown(KeyCode.F9))
                {
                    isLocked = true;
                }*/
    }

    void OnCollisionEnter(Collision floor) {
        if (floor.collider.tag == "Floor") {
            isGrounded = true;
        }
    }
}
