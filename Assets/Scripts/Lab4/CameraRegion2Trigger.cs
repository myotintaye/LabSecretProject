using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRegion2Trigger : MonoBehaviour {

    public CameraFollow cameraFollow;


    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("entering region 2");
            cameraFollow.useBuffer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("exiting region 2");
            cameraFollow.useBuffer = false;
        }
    }
}
