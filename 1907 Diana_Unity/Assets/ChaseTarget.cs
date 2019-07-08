using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTarget : MonoBehaviour
{
    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        Chase(ChooseTarget());
    }


    GameObject ChooseTarget()
    {
        GameObject target = GameObject.Find("Mage");
        return target;
    }

    void Chase(GameObject target)
    {
        Vector3 direction = target.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        this.transform.Translate(0, 0, speed);
    }

}
