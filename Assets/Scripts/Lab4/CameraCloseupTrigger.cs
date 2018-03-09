using UnityEngine;

public class CameraCloseupTrigger : MonoBehaviour
{
    public Camera mainCamera;
    public Camera closeUpCamera;

    public float zoomFactor = 0.5f;

    private float defaultViewSize;


    void Start()
    {
        defaultViewSize = closeUpCamera.orthographicSize;
    }

    // Defined by unity
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(closeUpCamera.orthographicSize);
            mainCamera.enabled = false;
            closeUpCamera.enabled = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            closeUpCamera.orthographicSize = defaultViewSize/other.transform.position.x * zoomFactor ;
        }
        

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            closeUpCamera.enabled = false;
            mainCamera.enabled = true;
            closeUpCamera.orthographicSize = defaultViewSize;
        }
    }
}
