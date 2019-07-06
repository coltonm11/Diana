#pragma strict

var speed : float = 12.0;
var rig : Rigidbody;
var arenaWidth : float = 10;
var arenaHeight : float = 10;
var lookBall : GameObject;

function Start () {
	rig = GetComponent.<Rigidbody>();
}

function Update () {

	var hAxis : float = Input.GetAxis("Horizontal");
	var vAxis : float = Input.GetAxis("Vertical");

	var mousePos : Vector3 = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height, 0);
	var lookX : float = arenaWidth * mousePos.x;
	var lookZ : float = arenaHeight * mousePos.y;


	var lookPoint : Vector3 = new Vector3(lookX - arenaWidth/2, this.transform.position.y, lookZ - arenaHeight/2);


	var movement : Vector3 = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

	lookBall.transform.position = lookPoint;

	rig.transform.LookAt(lookPoint);
	rig.MovePosition(transform.position + movement);


	//print(mousePos);
	//print(lookPoint);

}
  