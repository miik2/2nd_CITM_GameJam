using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation);

		if(other.tag == "Player"){
		Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}

        else
        {
            Score_Script.AddScore(10);
        }

		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}