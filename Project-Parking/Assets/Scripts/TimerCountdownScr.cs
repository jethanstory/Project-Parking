using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdownScr : MonoBehaviour
{
    public Text Txt;
    public float mainTime = 60f;

    public GameObject mainPlayer;
    public GameObject mainAICar;

    public GameObject loseSound;
    public GameObject mainTheme;

    public GameObject timeElapsedCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainTime -= Time.deltaTime;

        Txt = GameObject.Find ("MainText").GetComponent<Text> ();
        Txt.text = mainTime.ToString("F2");

        if (mainTime <= 0)
        {
            mainTime = 0;
            Txt.text = "0";
            loseSound.SetActive(true);
            mainTheme.SetActive(false);
            timeElapsedCanvas.SetActive(true);
            GameObject.Find("3DPlayer").GetComponent<PauseMenuScr>().enabled = false;
            GameObject.Find("3DPlayer").GetComponent<RotateMovement>().enabled = false;
            GameObject.Find("CarAI").GetComponent<FollowingEnemy>().enabled = false;
            GameObject.Find("CarAI").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<AdvancedWanderAI>().enabled = false;
            GameObject.Find("CarAICop").GetComponent<ChasePlayer>().enabled = false;
            //SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None;
        }

        if (mainAICar.GetComponent<SpaceStolenTrigger>().canRun)
        {
            mainTime = 100;
            Txt.text = "0";
        }
        if (mainPlayer.GetComponent<LevelLoader3D>().hasCrashed)
        {
            mainTime = 100;
            Txt.text = "0";
        }
        // if (mainPlayer.)
    }
}
