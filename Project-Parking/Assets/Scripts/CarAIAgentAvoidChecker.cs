/*
    Script to check to see if other AI Agent is too close to the current AI Agent,
    if so then Enable AIAvoidRunAway and Disable AdvancedWanderAI GameObject on the current AI Agent 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarAIAgentAvoidChecker : MonoBehaviour
{
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float damping;

    public Transform fpsTarget;
    public Transform fpsWanderTarget;
    Rigidbody theRigidBody;

    //public bool timerStarted = true;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
       //myRenderer = GetComponent<Renderer>();
       theRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //resetSystem();
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance) {
            //myRenderer.material.color = Color.yellow;
            //Disables the Advanced Wander AI script and the NavMeshAgent script so the enemy stops when you are in range. 
            GameObject.Find("CarAI").GetComponent<AdvancedWanderAI>().enabled = false;
            //GameObject.Find("CarAI").GetComponent<AIAvoidRunAway>().enabled = true;
        }
        
        else{
            GameObject.Find("CarAI").GetComponent<AIAvoidRunAway>().enabled = false;
            //GameObject.Find("CarAI").GetComponent<AdvancedWanderAI>().enabled = true;
        }
}
}
