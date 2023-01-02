/*
    Script that loads next level on player going into a parking space 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader3D : MonoBehaviour
{

    public GameObject canvas;
    public GameObject canvas2;
    public GameObject crashSound;
    public GameObject winSound;
    public GameObject mainTheme;
    private bool levelChange;
   // Start is called before the first frame update


   void Start ()
   {
        canvas.SetActive(false);
        crashSound.SetActive(false);
        winSound.SetActive(false);
        
   }
    void OnTriggerEnter(Collider other){
              //other.name should equal the root of your Player object
            if (other.gameObject.tag == "LevelTrigger") {
                //The scene number to load (in File->Build Settings)
                //SceneManager.LoadScene ("Level_2");
                levelChange = true;
                Debug.Log("He's done ya again");
                canvas2.SetActive(true);
                winSound.SetActive(true);
                mainTheme.SetActive(false);
                GameObject.Find("3DPlayer").GetComponent<RotateMovement>().enabled = false;
                GameObject.Find("3DPlayer").GetComponent<PauseMenuScr>().enabled = false;
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //SceneManager.LoadScene ("YouWon");
                Cursor.lockState = CursorLockMode.None;
            }
            //   else if (other.tag == "CollisionObject") {
            //       //The scene number to load (in File->Build Settings)
            //       //SceneManager.LoadScene ("Level_2");
            //       levelChange = true;
            //       Debug.Log("HIT");
            //       SceneManager.LoadScene ("GameOver");
            //       Cursor.lockState = CursorLockMode.None;
            //   }
            else {
                levelChange = false;
            }
          }

    void OnCollisionEnter (UnityEngine.Collision collisionInfo) 
    {
       if (collisionInfo.collider.tag == "CollisionObject")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canvas.SetActive(true);
            crashSound.SetActive(true);
            mainTheme.SetActive(false);
            GameObject.Find("3DPlayer").GetComponent<PauseMenuScr>().enabled = false;
            GameObject.Find("3DPlayer").GetComponent<RotateMovement>().enabled = false;
            GameObject.Find("CarAI").GetComponent<FollowingEnemy>().enabled = false;
            GameObject.Find("CarAI").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = false;
            //SceneManager.LoadScene("YouCrashed");
            Debug.Log("HIT");
            
        }
        
    }

    // void OnBecameInvisible() {
    //     //Destroy(PlayerGameObject);
    //     //Application.Quit();

    //     if (levelChange == false) {
    //         SceneManager.LoadScene("GameOver");
    //         Debug.Log("He's done ya again");
    //     }
        /*
        else {
            
            SceneManager.LoadScene ("YouWon");
            levelChange = false;
            
            
        }
        */
    //}
}
