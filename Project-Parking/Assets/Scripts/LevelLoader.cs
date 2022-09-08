using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private bool levelChange;


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
              //other.name should equal the root of your Player object
              if (other.name == "ParkingTrigger") {
                  //The scene number to load (in File->Build Settings)
                  //SceneManager.LoadScene ("Level_2");
                  levelChange = true;
                  SceneManager.LoadScene ("YouWon");
                  Cursor.lockState = CursorLockMode.None;
              }
              else {
                  levelChange = false;
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
    /*      
    void OnDestroy()
    {
        if (levelChange == true)
        {
            levelChange = false;
        }
    }
    */
}
