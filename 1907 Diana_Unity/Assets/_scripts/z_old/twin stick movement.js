#pragma strict

private var xVelAdj : float;
private var yVelAdj : float;
private var xFace : float;
private var yFace : float;
private var rig : Rigidbody;

var speed : float;

function Start () {
	rig = GetComponent.<Rigidbody>();
}

function Update () {
	xVelAdj = Input.GetAxis ("xMove");
	yVelAdj = Input.GetAxis ("yMove");

	xFace = Input.GetAxis ("xFace");
	yFace = Input.GetAxis ("yFace");
	var angle : float = Mathf.Atan2(xFace, yFace);

	if ( xFace + yFace != 0){
			rig.transform.rotation = Quaternion.EulerAngles(0, angle, 0);
	}

	rig.velocity = new Vector3 (speed*xVelAdj, 0, speed*yVelAdj);

}
