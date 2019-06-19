using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnemy_Movement : MonoBehaviour
{
    public float speed = 1.0f;

    public Transform targetToFollow;
    public Transform shotSpawn;

    public GameObject shot;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, targetToFollow.position) > 5)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetToFollow.position.x, targetToFollow.position.y, transform.position.z), speed * Time.deltaTime);

        else
        {
            shotSpawn.position = Vector3.MoveTowards(shotSpawn.position, new Vector3(targetToFollow.position.x, targetToFollow.position.y, transform.position.z), speed * Time.deltaTime);
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

        }
    }
}
