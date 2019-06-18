using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnemy_Movement : MonoBehaviour
{
	public float tumble;

    void Start()
    {
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    void Update()
    {
        
    }
}
