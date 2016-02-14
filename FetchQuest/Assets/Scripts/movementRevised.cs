using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class movementRevised : MonoBehaviour {
    public float speed = 7.5f;
    public float jumpSpeed = 15.0f;
    public float gravity = 20.0f;
    public int escaped = 0;
    private Vector3 moveDirection = Vector3.zero;
    private float mouseX = 0.0f;
    private float mouseY = 0.0f;

    void Update () {
        CharacterController controller = GetComponent<CharacterController>();

        SpeedTest();
        Moving();
        Rotator();
    }

    void SpeedTest()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 3.75f;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            speed = 15.0f;
        }
        else
        {
            speed = 7.5f;
        }
    }

    void Moving()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void Rotator()
    {
        mouseX = (Input.mousePosition.x - Screen.width / 2) / 2 + 0.5f;
        mouseY = -(Input.mousePosition.y - Screen.height / 2) / 2 + 9f;
        if (mouseX > 180)
        {
            mouseX -= 360;
        }
        else if (mouseX < -180)
        {
            mouseX += 360;
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
    }
}
