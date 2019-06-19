using UnityEngine;using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard1;
	public Vector3 spawnArea1;
	public int numSpawns1 = 3;

    public GameObject hazard2;
    public Vector3 spawnArea2;
    public int numSpawns2 = 3;

    public GameObject hazard3;
    public Vector3 spawnArea3;
    public int numSpawns3 = 3;

    public float spawnWait;
	public float startWait;
	public float waveWait;

    private float timer;

	void Start ()
	{
		StartCoroutine (SpawnWaves ());
        timer = Time.time + startWait + spawnWait * numSpawns1 * numSpawns2 * numSpawns3 + waveWait;
	}

    private void Update()
    {
        //if (Time.time > timer)
        //{
        //    StartCoroutine(SpawnWaves());
        //   //timer = Time.time + spawnWait * numSpawns1 * numSpawns2 * numSpawns3 + waveWait;
        //}
    }

    IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds(startWait);

		while (true) {
			for (int i = 0; i < numSpawns1; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnArea1.x, spawnArea1.x), Random.Range(0, spawnArea1.y), spawnArea1.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard1, spawnPosition, spawnRotation);
				yield return new WaitForSeconds(spawnWait);
			}

            for (int i = 0; i < numSpawns2; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnArea2.x, spawnArea2.x), spawnArea2.y, spawnArea2.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard2, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            for (int i = 0; i < numSpawns3; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnArea3.x, spawnArea3.x), Random.Range(0, spawnArea3.y), spawnArea3.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard3, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            numSpawns1 += 2;
            numSpawns2 += 1;
            numSpawns3 += 2;

            yield return new WaitForSeconds(waveWait);
		}
	}
}