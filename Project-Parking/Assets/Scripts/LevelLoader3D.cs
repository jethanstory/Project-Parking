using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader3D : MonoBehaviour
{
    private bool levelChange;
   // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
              //other.name should equal the root of your Player object
              if (other.gameObject.tag == "LevelTrigger") {
                  //The scene number to load (in File->Build Settings)
                  //SceneManager.LoadScene ("Level_2");
                  levelChange = true;
                  Debug.Log("He's done ya again");
                  SceneManager.LoadScene ("YouWon");
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
            SceneManager.LoadScene("GameOver");
            Debug.Log("HIT");
            
        }
        
    }

    void OnBecameInvisible() {
        //Destroy(PlayerGameObject);
        //Application.Quit();

        if (levelChange == false) {
            SceneManager.LoadScene("GameOver");
            Debug.Log("He's done ya again");
        }
        /*
        else {
            
            SceneManager.LoadScene ("YouWon");
            levelChange = false;
            
            
        }
        */
    }
}
