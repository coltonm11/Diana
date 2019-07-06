#pragma strict

var player : GameObject;


function Start () {
	player = GameObject.Find("Champion");
}

function Update () {
	var direction : Vector3 = player.transform.position - this.transform.position;

	this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

	this.transform.Translate(0, 0, 0.01f);

	this.transform.position.y = 0;
}


