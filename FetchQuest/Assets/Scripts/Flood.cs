using UnityEngine;
using System.Collections;

public class Flood : MonoBehaviour {

    private Rigidbody rb;
    float waterLevel = 5f;
    float floatHeight = 2f;
    float bounceDamp = 0.05f;
    Vector3 bouancyCenterOffset;

    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 upLift;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        actionPoint = transform.position + transform.TransformDirection(bouancyCenterOffset);
        forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);

        if(forceFactor > 0f)
        {
            upLift = -Physics.gravity * (forceFactor - rb.velocity.y * bounceDamp);
            rb.AddForceAtPosition(upLift, actionPoint);
        }
    }
}
