using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbscript : MonoBehaviour
{
	public Rigidbody2D myRigidbody;
	public float flapStrength;
	public LogicScript logic;
	public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
		if (myRigidbody.position.y > 13.11 || myRigidbody.position.y < -13.34)
		{
			logic.gameOver();
		}
		if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true )
		{
        	myRigidbody.velocity = Vector2.up * flapStrength;
		}
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		logic.gameOver();
		birdIsAlive = false;
	}
}
