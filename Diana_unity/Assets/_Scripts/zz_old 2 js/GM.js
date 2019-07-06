#pragma strict

var skelly : GameObject;
var rangeLow : float;
var rangeHigh : float;

private var spawnDelay : boolean;



function Start () {
	spawnDelay = false;
}




function Update () {

	if (!spawnDelay) {
		Instantiate(skelly, new Vector3 (Random.Range(rangeLow,rangeHigh), 0, Random.Range(rangeLow,rangeHigh)), skelly.transform.rotation);
		spawnDelay = true;
		spawnReset();
	}
}



function spawnReset() {
	yield WaitForSeconds (2);
	spawnDelay = false;
}
