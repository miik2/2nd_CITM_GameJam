using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;

    public float speed = 5f;
    public float rotateSpeed = 200f;
    public float activeTime = 5.0f;
    public GameObject explosion;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        activeTime = Time.time + activeTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > activeTime)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        else
        {
            Vector2 direction = (Vector2)target.position - rb.position;

            direction.Normalize();

            float rotateAmount = Vector3.Cross(direction, transform.up).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;

            rb.velocity = transform.up * speed;
        }
    }
}
