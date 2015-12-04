using UnityEngine;
using System.Collections;

public class movementComputer : MonoBehaviour {
    private Rigidbody rb;
    private bool isGrounded = true;
    private bool sprinting = false;
    private bool sneaking = false;
    private bool isLocked = true;
    private float mouseX;
    private float mouseY;
    private float lockMouse;
    private float lockDelay;

    public float jumpHeight = 8f;
    public float moveSpeed = .3f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            isLocked = false;
            Cursor.visible = true;
        }
        lockDelay++;
        if(lockDelay == 1f && isLocked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else if (lockDelay > 1f && isLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            lockDelay = 0f;
        }
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            sprinting = true;
        }
        else
        {
            sprinting = false;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            sneaking = true;
        }
        else
        {
            sneaking = false;
        }

        if (sprinting || sneaking)
        {
            if (sprinting)
            {
                transform.Translate(moveHorizontal * moveSpeed * 2f, 0.0f, moveVertical * moveSpeed * 2f, Space.Self);
            }
            else
            {
                transform.Translate(moveHorizontal * moveSpeed * .5f, 0.0f, moveVertical * moveSpeed * .5f, Space.Self);
            }
        }
        else
        {
            transform.Translate(moveHorizontal * moveSpeed, 0.0f, moveVertical * moveSpeed, Space.Self);
        }

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
        if (mouseY < -70) 
        {
            mouseY = -70;
        }
        else if (mouseY > 90)
        {
            mouseY = 90;
        }

        Camera.main.transform.eulerAngles = new Vector3(mouseY, mouseX, 0.0f);

        if (isLocked)
        {
            mouseX += (Input.mousePosition.x - Screen.width / 2) / 2 + .5f;
            mouseY -= (Input.mousePosition.y - Screen.height / 2) / 2 - 9f;
        }
        else
        {
            mouseX = (Input.mousePosition.x - Screen.width / 2) / 2 + .5f;
            mouseY = -(Input.mousePosition.y - Screen.height / 2) / 2 - 9f;
        }
    }

    void OnCollisionEnter(Collision floor) {
        if (floor.collider.tag == "Floor") {
            isGrounded = true;
        }
    }
}
