using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToGameOver : MonoBehaviour
{

	public Image fadeblack;
	public float timetofade;
	private float timeleft;

	private bool startcounter;
	private bool goingToMenu;
	private bool restartingGame;

	void Start ()
	{
		fadeblack.canvasRenderer.SetAlpha(0.0f);
		timeleft = timetofade;
		startcounter = false;
		goingToMenu = false;
		restartingGame = false;

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			fadeIn();
			startcounter = true;
			restartingGame = true;
		}
		else if (Input.GetKeyDown(KeyCode.M))
		{
			fadeIn();
			startcounter = true;
			goingToMenu = true;			
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
		{
			if (goingToMenu) SceneManager.LoadScene("MainMenu");
			if (restartingGame) SceneManager.LoadScene("Ingame");
		}


	}

	void fadeIn()
	{
		fadeblack.CrossFadeAlpha(1, timetofade, false);
	} 

}
