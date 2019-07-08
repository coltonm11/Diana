using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_WASD : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed;

    Camera cam;
    GameObject player;

    public GameObject[] ball;

    int layerMask = 1 << 9;

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

        RotateCharacter(GetMousePosition());

    }

    private Vector3 GetMousePosition()
    {

        Vector3 startPos = cam.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
        Vector3 endPos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.farClipPlane));

        RaycastHit hit;
        Ray ray = new Ray(startPos, endPos - startPos);


        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {

        }

        return hit.point;

    }

    private void RotateCharacter(Vector3 mousePos)
    {
        Vector3 lookDirection = new Vector3(mousePos.x, this.transform.position.y, mousePos.z);
        this.transform.LookAt(lookDirection);
    }


}
