using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedingCheck : MonoBehaviour
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
            if (Input.GetKey("left shift"))
            {
            //myRenderer.material.color = Color.yellow;

            //Disables the Advanced Wander AI script and the NavMeshAgent script so the enemy stops when you are in range. 
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = true;
            //gameObject.GetComponent<NavMeshAgent>().enabled = false;
            //lookAtPlayer();
            
            //if (fpsTargetDistance < attackDistance) {
                //GameObject.Find("WanderingEnemy").GetComponent<FollowingEnemy>().enabled = false;
                //GameObject.Find("WanderingEnemy").GetComponent<AttackPlayer>().enabled = true;
                //myRenderer.material.color = Color.red;
                //attackPlease();
            //}
            }
            
        }
        
        else{
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = true;
            //gameObject.GetComponent<NavMeshAgent>().enabled = true;
            
            
            //Wander to player position
            //WandertoPlacePlease();

            //myRenderer.material.color = Color.blue;
            //enemyLight.color = Color.white;
          
        }
    }

    // void resetSystem()
    // {
    //    // if(!timerStarted)
    //     //{
    //     //    timerStarted = true;
    //     //    timer = 0.0f;
    //     //}
    //     //else
    //     //{
    //     timer += Time.deltaTime;
    //     //}
    //     if(timer >= 5.0f)
    //     {
    //         GameObject.Find("WanderingEnemy").GetComponent<AdvancedWanderAI>().enabled = false;
    //         GameObject.Find("WanderingEnemy").GetComponent<FixerFollow>().enabled = true;
    //         //timerStarted = false;
    //         if(timer >= 7.0f)
    //         {
    //             timer = 0.0f;
    //             GameObject.Find("WanderingEnemy").GetComponent<AdvancedWanderAI>().enabled = true;
    //             GameObject.Find("WanderingEnemy").GetComponent<FixerFollow>().enabled = false;
    //         }
            
    //     }
            
        //else
        //{
        //    timerStarted = false;
        //}
        
    //}

}
