using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score_Script.scoreValue = 0;
        Score_Script.scoreText.text = "Score: " + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
