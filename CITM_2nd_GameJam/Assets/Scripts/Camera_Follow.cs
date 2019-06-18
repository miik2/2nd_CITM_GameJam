using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public GameObject player;
    private Vector2 velocity;

    private float Py;
    private float Px;

    public float smoothX;
    public float smoothY;

    public bool bounds;

    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Px = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothX);
        Py = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothY);
        transform.position = new Vector3(Px, Py, transform.position.z);

        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
               Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
        }

    }

}

