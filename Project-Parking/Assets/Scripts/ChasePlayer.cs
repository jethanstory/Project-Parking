/*
    Script for having the parking cop AI chase after the player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    public float damping;

    public NavMeshAgent agent;
    public NavMeshAgent fpsTarget;
    public Transform player;

    // Start is called before the first frame update

    [Range(0, 100)] public float speed;
    [Range(1, 500)] public float walkRadius;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (agent != null)
        {
            agent.speed = speed;
            agent.avoidancePriority = 0;
            agent.SetDestination(player.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
        
        //transform.LookAt(player);
        agent.SetDestination(player.position);
        

    }
}
