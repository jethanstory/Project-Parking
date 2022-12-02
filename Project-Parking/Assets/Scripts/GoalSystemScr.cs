using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        secondsCount += Time.deltaTime;

        if (secondsCount > 5) 
        {
            text.SetActive(false);
        }
    }
}
