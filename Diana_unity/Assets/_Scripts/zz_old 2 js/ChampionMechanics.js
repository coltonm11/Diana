#pragma strict

private var bash : float;
private var animator: Animator;
var recieveInput : boolean;
var bashAction : boolean;

var health : int;

private var trigger;

function Start () {
	bash = Input.GetAxis ("Action1");
	animator = GetComponent.<Animator>();
 	//bashed = false;
 	//bashedMore = false;
 	recieveInput = true;
 	bashAction = false;

 	var shield = GameObject.Find("Shield");
 	Physics.IgnoreCollision(shield.GetComponent.<MeshCollider>(), GetComponent.<Collider>());
}

function Update () {

	trigger = Input.GetAxis("Action1");

	if (recieveInput && trigger != 0) {
		animator.SetTrigger("bash");
		recieveInput = false;
		bashAction = true;

	}

	if (trigger == 0) {
		recieveInput = true;
		bashAction = false;
	}

	if (health <= 0) {
		print ("dead");
	}
}



function Bash (target : Rigidbody, targetPos : Transform) {
	//var rb : Rigidbody = target.GetComponent.<Rigidbody>();
	var direction : Vector3 = target.transform.position - this.transform.position;
	var shieldStrength : float = Vector3.Distance(targetPos.position, this.GetComponent.<Transform>().position);
	target.velocity = (direction*10)/shieldStrength;
}