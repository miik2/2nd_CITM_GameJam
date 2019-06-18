using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutScript : MonoBehaviour
{

    public Image fadeblack;

    void Start()
    {
        fadeblack.canvasRenderer.SetAlpha(1.0f);

    }

    void Update()
    {
            fadeIn();
    }

    void fadeIn()
    {
        fadeblack.CrossFadeAlpha(0, 2, false);
    }

}
