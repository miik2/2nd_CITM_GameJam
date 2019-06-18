using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
	public float speed;
	private Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {	
		player = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        player.AddForce(movement * speed);
    }
}
