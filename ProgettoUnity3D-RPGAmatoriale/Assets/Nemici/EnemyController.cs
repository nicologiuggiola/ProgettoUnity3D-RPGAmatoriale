﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius)
        {
            transform.LookAt(target);
            //FaceTarget();
            //transform.LookAt(target, Vector3.left);
            agent.SetDestination(target.position);

           // if (distance <= agent.stoppingDistance)
            //{
               // transform.LookAt(target);
                //FaceTarget();
                //transform.LookAt(target, Vector3.left);
            //}
        }
    }

   // void FaceTarget ()
   // {
   //     Vector3 direction = (target.position - transform.position).normalized;
   //     Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
    //    transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    //}
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}