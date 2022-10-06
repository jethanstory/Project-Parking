using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour
{
    public bool isFlickering;
    public int FlickerMode;
    public float FlickerTime;

    public GameObject lightSource;

    public Light light;

     private float restartIn = 1f; //1


    
    public float RandomIntensity;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isFlickering = true;
        StartCoroutine(FlickerLight());
    }


    IEnumerator FlickerLight()
    {
        if (FlickerMode == 1)
        {
            //this.gameObject.GetComponent<Light>().enabled = false;
            lightSource.SetActive(false);
            FlickerTime = Random.Range(0f, 0.26f);
            RandomIntensity = Random.Range(0f, 3.1f);
            light.intensity = RandomIntensity;
            FlickerTime = Random.Range(0f, 0.05f);
            yield return new WaitForSeconds(FlickerTime);
            RandomIntensity = Random.Range(0f, 3.1f);
            light.intensity = RandomIntensity;
            lightSource.SetActive(true);
            //this.gameObject.GetComponent<Light>().enabled = true;
            isFlickering = false;
        }
    }
}
