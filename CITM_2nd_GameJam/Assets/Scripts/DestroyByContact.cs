using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter2D(Collider2D other) 
	{
		if ((gameObject.tag == "Enemy" && other.gameObject.tag == "Enemy") || (gameObject.tag == "Player" && other.gameObject.tag == "Torpede") || (gameObject.tag == "Torpede" && other.gameObject.tag == "Player"))
        {
            return;
        }
        else
        {
            if (other.tag == "Boundary")
            {
                return;
            }

            Instantiate(explosion, transform.position, transform.rotation);

            if (other.tag == "Player")
            {
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            }

            if (gameObject.tag == "Torpede" && other.gameObject.tag == "Enemy" || gameObject.tag == "Enemy" && other.gameObject.tag == "Torpede")
            {
                Score_Script.AddScore(10);
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
            
        
    }
		
}