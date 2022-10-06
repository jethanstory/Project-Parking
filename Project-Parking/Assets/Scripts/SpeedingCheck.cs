/*
    Script that checks if the player is speeding within a certain distance from the parking cop AI
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedingCheck : MonoBehaviour
{
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float enemyMovementSpeed;
    public float damping;

    public Transform fpsTarget;
    public Transform fpsWanderTarget;
    Rigidbody theRigidBody;

    public GameObject lightSource;

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
            if (Input.GetKey("left shift"))
            {
            //myRenderer.material.color = Color.yellow;

            //Disables the Advanced Wander AI script and the NavMeshAgent script so the enemy stops when you are in range. 
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = true;
            lightSource.SetActive(true);
            GameObject.Find("CarAICop").GetComponent<FlashingLight>().enabled = true;

           
            }
            
        }
        
        else{
            lightSource.SetActive(false);
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = true;
            GameObject.Find("CarAICop").GetComponent<FlashingLight>().enabled = false;
            
        }
    }

    
}
