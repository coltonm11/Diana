#pragma strict

private var rb: Rigidbody;
//private var shieldStrength: Vector3;
var champion : GameObject;
//var multiplier : float;


function Start () {
	rb = GetComponent.<Rigidbody>();
	champion = GameObject.Find("Champion");
}

function Update () {
	
}

/*

function OnTriggerStay(other : Collider) {
	if (other.name == "Shield" & champion.GetComponent.<ChampionMechanics>().bashAction) {
		champion.GetComponent.<ChampionMechanics>().Bash(this.GetComponent.<Rigidbody>(), this.GetComponent.<Transform>());
	}
}


function OnTriggerEnter(other : Collider) {
	if (other.name == "Champion") {
		print("triggered");
		champion.GetComponent.<ChampionMechanics>().health--;
		//print("Champion one is at " champion.GetComponent.<ChampionMechanics>().health);
	}

}*/
