using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {

    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;

    public Sprite rightSprite;
    public Sprite leftSprite;
    public Sprite stillSprite;

    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
	}
	

    //Fixed Update is called before any physics operations
    private void FixedUpdate()
    {
        // Make the ghost move with the arrow keys
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector2 vel = rb.velocity;
        vel.x = moveH;
        vel.y = moveV;
        rb.velocity = vel;

        //Key down on enter functionality
        if (Input.GetKeyDown(KeyCode.Space)) {

        }

        //Make the ghost look the correct direction when moving
        if (vel.x > 0) {
            mySpriteRenderer.sprite = rightSprite;
        }
        else if (vel.x < 0) {
            mySpriteRenderer.sprite = leftSprite;
        }
        else {
            mySpriteRenderer.sprite = stillSprite;
        }

    }
}
