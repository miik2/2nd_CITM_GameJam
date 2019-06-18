using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
	public float speed;
	private Rigidbody2D player;
    private float rotationSpeed = 0;
    public float RotationSmoothing;
    // Start is called before the first frame update
    void Start()
    {	
		player = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);

        if (Input.GetKey(KeyCode.W))
            player.velocity = -transform.right * speed;

        if (Input.GetKey(KeyCode.S))
            player.velocity = transform.right * speed;

        if (Input.GetKey(KeyCode.A))
            rotationSpeed = 2;

        if (Input.GetKey(KeyCode.D))
            rotationSpeed = -2;

        player.AddForce(transform.forward * speed);

        if (rotationSpeed > 0)
            rotationSpeed -= RotationSmoothing;
        else if (rotationSpeed < 0)
            rotationSpeed += RotationSmoothing;
    }

}
