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
        if (Input.GetKey(KeyCode.W))
            player.velocity = transform.up * speed;

        if (Input.GetKey(KeyCode.S))
            player.velocity = -transform.up * speed;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, 3);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, -3);

        player.AddForce(transform.forward * speed);
    }

}
