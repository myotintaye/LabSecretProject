using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour {


    public GameObject boyGameObject;
    public Sprite boySprite;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {
       
        sRend = boyGameObject.GetComponent<SpriteRenderer>();
    }
	void OnMouseDown()
    {
       
        sRend.sprite = boySprite;

    }
}
