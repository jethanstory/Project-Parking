/*
    Script for parking cop AI to check to see if other AI agent is too close, if so then activate avoidance script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopAIAvoidChecker : MonoBehaviour
{
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float damping;

    public Transform fpsTarget;
    public Transform fpsWanderTarget;
    Rigidbody theRigidBody;

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
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AIAvoidRunAway>().enabled = true;
        }
        
        else{
            GameObject.Find("CarAICop").GetComponent<AIAvoidRunAway>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = true;
          
        }
}
}
