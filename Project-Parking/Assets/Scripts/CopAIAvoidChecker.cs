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
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;

    public GameObject lightSource;
    public Transform fpsTarget;
    public Transform fpsWanderTarget;
    Rigidbody theRigidBody;

    //public Transform stuckCheck;
    //Renderer myRenderer;

    private bool lightEnabled;
    //public GameObject[] sounds;
    public GameObject[] lights;

    //public bool timerStarted = true;
    public float timer = 0.0f;

    //public AudioSource audioSource;

    //private Light enemyLight;
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
             
            //gameObject.GetComponent<NavMeshAgent>().enabled = false;
            //lookAtPlayer();
            
            //if (fpsTargetDistance < attackDistance) {
                //GameObject.Find("WanderingEnemy").GetComponent<FollowingEnemy>().enabled = false;
                //GameObject.Find("WanderingEnemy").GetComponent<AttackPlayer>().enabled = true;
                //myRenderer.material.color = Color.red;
                //attackPlease();
            //}
        }
        
        else{
            GameObject.Find("CarAICop").GetComponent<AIAvoidRunAway>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = true;
             
            //gameObject.GetComponent<NavMeshAgent>().enabled = true;
            
            
            //Wander to player position
            //WandertoPlacePlease();

            //myRenderer.material.color = Color.blue;
            //enemyLight.color = Color.white;
          
        }
}
}
