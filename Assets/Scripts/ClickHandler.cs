using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    public GameObject robotBoy;
    private Rigidbody2D rBody;
    public Sprite firstSprite;
    public Sprite secondSprite;
    private SpriteRenderer sRend;
    public float Speed =1.0f;

    void Start () {
        //Debug.Log(robotBoy);
        rBody = robotBoy.GetComponent<Rigidbody2D>();
        sRend = robotBoy.GetComponent<SpriteRenderer>();
        rBody.velocity = new Vector2(2,0);
        //robotBoy.GetComponent<Rigidbody2D>().velocity = new Vector2(2,0);

        
	}
	
    //executes when a mouse down event is fired on the attached object
    void OnMouseDown()
    {
        rBody = robotBoy.GetComponent<Rigidbody2D>();
        rBody.velocity *= -1;

        if(sRend.sprite == firstSprite)
        {
            sRend.sprite = secondSprite;
        }
        else
        {
            sRend.sprite = firstSprite;
        }
      
      
    }
}
