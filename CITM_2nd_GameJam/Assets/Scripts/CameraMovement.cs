using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    public float speed;

    private int SceneManagerBoolean;

    // Start is called before the first frame update
    void Start()
    {
        SceneManagerBoolean = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, -10);


        if (Input.GetKeyDown(KeyCode.Return))
        {
            //if (SceneManagerBoolean == 1)
            //{
            //    SceneManagerBoolean = 2;
            //}
            //else
            //{
                SceneManager.LoadScene("Ingame");
            //}

        }
    }
}
