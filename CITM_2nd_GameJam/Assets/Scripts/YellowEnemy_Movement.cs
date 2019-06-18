using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnemy_Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform targetToFollow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetToFollow.position.x, targetToFollow.position.y, transform.position.z), speed * Time.deltaTime);
 
    }
}
