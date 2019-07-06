using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
// CONTAINS ATTACK CONTROLS, SHIELD BASH VALUES,
// IGNORE SHIELD COLLISIONS, CHAMPION HEALTH
//
public class ChampionBehavior : MonoBehaviour
{
    float trigger;
    Animator animator;
    bool recieveInput;
    public bool bashAction;
    int hp;

    void Start()
    {
        // Map to and assign variables
        animator = GetComponent<Animator>();
        // Initial values
        recieveInput = true;
        bashAction = false;
        hp = 2;
        // Ignore shield collisions (made with array incase multiple Chamnpions

        //GameObject shield = GameObject.FindGameObjectWithTag("Shield");
        //Physics.IgnoreCollision(shield.GetComponent<MeshCollider>(), this.GetComponent<Collider>());
        ///*
        GameObject[] shields;
        shields = GameObject.FindGameObjectsWithTag("Shield");
        foreach (GameObject shield in shields)
        {
            //Physics.IgnoreCollision(shield.GetComponent<CapsuleCollider>(), GetComponent<Collider>());
        }
        //*/
    }


    void Update()
    {
        // CONTROLLER STUFF_____________________________________
        trigger = Input.GetAxis("Action1");
        // If controller trigger inactive, keep everything still
        if (trigger == 0)
        {
            recieveInput = true;
            bashAction = false;
        }
        // If controller has any value, trigger the bash, which is an animation only.
        if (recieveInput && trigger != 0)
        {
            animator.SetTrigger("bash");
            recieveInput = false;
            bashAction = true;
        }

        // HEALTH__________________________________________
        if (hp <= 0)
        {
            print("dead");
        }
    }

    // SHIELD BASH _______________________________________________
    // Function to be called by an enemy's OnTriggerEnter()
    public void ShieldBash(Rigidbody target, Transform targetPos)
    {
        Vector3 direction = target.transform.position - this.transform.position;
        target.velocity = (direction * 10);
    }
}
