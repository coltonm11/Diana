using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayers : MonoBehaviour {

    public float speed;
    Rigidbody rb;
    GameObject player;

	void Start () {
        player = GameObject.Find("Champion");
        rb = this.GetComponent<Rigidbody>();
	}
	
	void Update () {
        Vector3 direction = player.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        //this.GetComponent<Rigidbody>().velocity += direction/5;
        this.transform.Translate(0, 0, speed);
       
        //Vector3 move = new Vector3(0, 0, speed);
       // rb.MovePosition(transform.position + move);
        
    }
}
