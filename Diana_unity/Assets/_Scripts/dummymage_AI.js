#pragma strict

var speed : float;
var rb : Rigidbody;

function Start () {
	rb = GetComponent.<Rigidbody>();
	move();
}

function Update () {
	
}

function move () {
	while(true) {
		rb.velocity = new Vector3(Random.Range(speed, speed*-1), 0, Random.Range(speed, speed*-1));
		yield WaitForSeconds(1);
	}
}