using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Script : MonoBehaviour
{
    public TextMesh scoreText;
    public static int scoreValue;

    private static bool mustUpdate;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMesh>();
        scoreValue = 0;
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (mustUpdate)
        {
            scoreText.text = "Score: " + scoreValue;
            mustUpdate = false;
        }
    }

    public static void AddScore(int addition)
    {
        scoreValue += addition;
        mustUpdate = true;
    }
}
