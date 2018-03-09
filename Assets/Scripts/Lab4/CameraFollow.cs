using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform playerPosition;
    public bool useBuffer = false;

    private Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!useBuffer)
          transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        else
        {
            if (playerPosition.position.x > transform.position.x || playerPosition.position.x <= transform.position.x - 5)
            {
                transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
            }



        }
       

    }

    void OnDrawGizmosSelected()
    {
        if (useBuffer)
        {
            Gizmos.color = Color.green;
            var threshPos = transform.position;
            Gizmos.DrawLine(threshPos, new Vector3(threshPos.x, threshPos.y + 50, threshPos.z));
            Gizmos.DrawLine(threshPos, new Vector3(threshPos.x, threshPos.y - 50, threshPos.z));

           // Gizmos.DrawLine(new Vector3(transform.position.x - 5, transform.position.y,transform.position.z), new Vector3(transform.position.x - 5, transform.position.y + 20,transform.position.z));

           
        }

    }
}
