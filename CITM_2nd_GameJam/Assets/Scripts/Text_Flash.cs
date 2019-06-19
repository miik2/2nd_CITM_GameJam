using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Flash : MonoBehaviour
{
    public GameObject flashing_Label;

    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FlashLabel", 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);
    }
}
