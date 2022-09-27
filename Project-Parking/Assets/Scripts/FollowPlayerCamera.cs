using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public float cameraDistOffset = 0;
     private Camera mainCamera;
     private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("3DPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 playerInfo = player.transform.transform.position;
         mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y - cameraDistOffset, playerInfo.z);
    }
}
