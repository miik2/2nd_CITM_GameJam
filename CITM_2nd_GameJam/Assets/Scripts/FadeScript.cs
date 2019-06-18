using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{

    public Image fadeblack;
    public float timetofade;
    private float timeleft;
    private bool startcounter;

    void Start ()
    {
        fadeblack.canvasRenderer.SetAlpha(0.0f);
        timeleft = timetofade;
        startcounter = false;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fadeIn();
            startcounter = true;
           
        }
        else
        {
            fadeblack.canvasRenderer.SetAlpha(0.0f);
        }

        if(startcounter == true)
        {
            timeleft -= Time.deltaTime;
        }

        if(timeleft <0)
            SceneManager.LoadScene("Ingame");


    }

    void fadeIn()
    {
        fadeblack.CrossFadeAlpha(1, timetofade, false);
    } 
    
 }
