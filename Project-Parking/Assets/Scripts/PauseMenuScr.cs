using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScr : MonoBehaviour
{
    public GameObject menuCanvas;
    public AudioSource musicAudio;

    private bool activeMenu; 

    // Start is called before the first frame update
    void Start()
    {
        activeMenu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            checkMenu();
            // Time.timeScale = 0;
            // menuCanvas.SetActive(true);
            // playerHudCanvas.SetActive(false);

            // if (Input.GetKeyDown(KeyCode.Escape))
            // {
            // activeMenu =
            // // Time.timeScale = 1;
            // // menuCanvas.SetActive(false);
            // // playerHudCanvas.SetActive(true);
            // }
        }


    }


    public void checkMenu()
    {   
        if (activeMenu)
        {
            activeMenu = false;
            Time.timeScale = 1;
            musicAudio.Play();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            menuCanvas.SetActive(false);
        }
        else
        {
            activeMenu = true;
            Time.timeScale = 0;
            musicAudio.Pause();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            menuCanvas.SetActive(true);

        }
    }
}
