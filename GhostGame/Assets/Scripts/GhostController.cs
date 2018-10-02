using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {

    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
	public float speed;

	// player movement sprites
    public Sprite rightSprite;
    public Sprite leftSprite;
    public Sprite stillSprite;
	public Sprite backSprite;

	// player movement helper variables
	private bool playerIsMoving;
	public Vector2 lastMove;

	// helper variables for changing areas
	private static bool playerExists;
	public string startPoint;

    // Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		mySpriteRenderer = GetComponent<SpriteRenderer> ();
		if (!playerExists) {
			playerExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
			
	

    //Fixed Update is called before any physics operations
    private void FixedUpdate()
    {	
		playerIsMoving = false;

        // Make the ghost move with the arrow keys
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

		if (moveH > 0f || moveH < 0f) {
			playerIsMoving = true;
			transform.Translate(new Vector3(moveH * speed * Time.deltaTime, 0f, 0f));
			lastMove = new Vector2 (moveH, 0f);
			if (moveH > 0f) {
				mySpriteRenderer.sprite = rightSprite;
			} else {
				mySpriteRenderer.sprite = leftSprite;
			}
		}
		if (moveV > 0f || moveV < 0f) {
			playerIsMoving = true;
			transform.Translate(new Vector3(0f, moveV * speed * Time.deltaTime, 0f));
			lastMove = new Vector2 (0, moveV);
			if (moveV > 0f) {
				mySpriteRenderer.sprite = backSprite;
			} else {
				mySpriteRenderer.sprite = stillSprite;
			}
		}

		// If not moving, make ghost face in direction of last move
		if (!playerIsMoving && lastMove.y > 0f) {
			mySpriteRenderer.sprite = backSprite;
		} else if (!playerIsMoving) {
			mySpriteRenderer.sprite = stillSprite;
		}

        //Key down on enter functionality
        if (Input.GetKeyDown(KeyCode.Space)) {

        }

    }
}
