using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necro_Behavior : MonoBehaviour {

    
    GameObject gm;
    // Skelly gameObject
    GameObject skelly;
    // Skelly spawn range
    float skellySpawnRHigh;
    float skellySpawnRLow;
    // Skelly spawn rate (delay between spawns)
    int skellySpawnDelay;
    bool delayActive;


	void Start () {
        // Grab GM from scene its parameters 
        gm = GameObject.FindGameObjectWithTag("GM");
        skelly = gm.GetComponent<GameMaster>().skelly;
        skellySpawnRHigh = gm.GetComponent<GameMaster>().skellySpawnRHigh;
        skellySpawnRLow = gm.GetComponent<GameMaster>().skellySpawnRLow;
        skellySpawnDelay = gm.GetComponent<GameMaster>().skellySpawnDelay;
        // Initial variable states
        delayActive = false;
    }
	

	void Update () {
        // make skelly spawn point relative to the necro
        float necroX = this.transform.position.x;
        float necroZ = this.transform.position.y;
        // Spawn a new Skelly, then kick off the reset timer.
        if (!delayActive)
        {
            Instantiate(skelly, new Vector3(Random.Range(necroX + skellySpawnRLow, necroX + skellySpawnRHigh), 0, Random.Range(necroZ + skellySpawnRLow, necroZ + skellySpawnRHigh)), skelly.transform.rotation);
            delayActive = true;
            StartCoroutine(SpawnReset());
        }
	}

    // Timer between skelly spawns
    IEnumerator SpawnReset()
    {
        yield return new WaitForSeconds(skellySpawnDelay);
        delayActive = false;
    }
}
