using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
// COLLISION AND TRIGGER EVENTS WITH PLAYERS AND ATTACKS
//
public class EnemyCombatBehavior : MonoBehaviour {

    Rigidbody rb;

	void Start () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        // SHIELD BASH
        if(other.tag == "Shield")
        {
            // create local player and ChampionBehavior scripts, to make it cleaner looking.
            GameObject player = other.transform.parent.gameObject;
            ChampionBehavior champ = player.GetComponent<ChampionBehavior>();
            // wait for bashAction to become true
            if (champ.bashAction)
            {
                champ.ShieldBash(this.GetComponent<Rigidbody>(), this.GetComponent<Transform>());
            }
        }
    }
}
