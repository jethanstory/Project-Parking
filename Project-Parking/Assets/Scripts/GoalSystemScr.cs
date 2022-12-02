using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalSystemScr : MonoBehaviour
{
    public float secondsCount;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();

        string sceneName = currentScene.name;
        secondsCount += Time.deltaTime;
        
        if (secondsCount > 5) 
        {
            text.SetActive(false);
        }
        
    }
}
