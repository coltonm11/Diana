using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_WASD : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed;

    Vector3 lookTarget;
    Camera cam;
    GameObject player;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = this.transform.gameObject;
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rb.velocity = (Vector3.left) * movementSpeed;
        if (Input.GetKey(KeyCode.D))
            rb.velocity = (Vector3.right) * movementSpeed;
        if (Input.GetKey(KeyCode.W))
            rb.velocity = (Vector3.forward) * movementSpeed;
        if (Input.GetKey(KeyCode.S))
            rb.velocity = (Vector3.back) * movementSpeed;

        LookAtMouse();
    }

    void LookAtMouse()
    {
        lookTarget = cam.ScreenToWorldPoint(Input.mousePosition);
        lookTarget.y = 0.5f;
        player.transform.LookAt(lookTarget, Vector3.forward);
    }
}
