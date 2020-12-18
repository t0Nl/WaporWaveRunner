using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tr;

    public float playerForwardSpeed = 2000f;
    public float playerSidewaysSpeed = 500f;
    public float playerRotationSpeed = 100f;
    public float playerRotationResetSpeed = 130f;
    public float playerRotationTreshold = 0.05f;

    void Start()
    {
        Debug.Log(tr.rotation.y);
    }

    void Update()
    {
        Debug.Log(tr.rotation.y);
        if (Input.GetKey("d"))
        {
            if (tr.rotation.y <= playerRotationTreshold)
            {
                tr.Rotate(0f, playerRotationSpeed * Time.deltaTime, 0f, Space.Self);
                Debug.Log(tr.rotation.y);
            }
        }
        else if (Input.GetKey("a"))
        {
            if (tr.rotation.y >= -playerRotationTreshold)
            {
                tr.Rotate(0f, -playerRotationSpeed * Time.deltaTime, 0f, Space.Self);
                Debug.Log(tr.rotation.y);
            }
        }
        if (tr.rotation.y >= 0.01f)
        {
            tr.Rotate(0f, -playerRotationResetSpeed * Time.deltaTime, 0f, Space.Self);
        }
        if (tr.rotation.y <= -0.01f)
        {
            tr.Rotate(0f, playerRotationResetSpeed * Time.deltaTime, 0f, Space.Self);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, playerForwardSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(playerSidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a"))
        {
            rb.AddForce(-playerSidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
