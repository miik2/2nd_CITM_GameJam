﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;

	void Start(){
		SpawnWaves();
	}

	void SpawnWaves()
	{
		Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}
