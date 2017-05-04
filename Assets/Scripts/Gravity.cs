using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour 
{
	public Rigidbody rb;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start () 
	{
		Physics.gravity = new Vector3 (0, 0, -1);

	}
	
	public void Respawn()
	{
		// To respawn the ship
		rb.isKinematic = false;
		transform.position = new Vector3(0, 5.16f, -2.5f);
	}

    private void OnTriggerEnter(Collider other)
    {
        // If obstacle has come into contact with a laser
        if (other.GetComponent<Laser>() != null)
        {
            // Create an explosion prefab clone
            GameObject clone = Instantiate(explosionPrefab);
            clone.transform.position = transform.position;

            // Grab the ParticleSystem from that explosion prefab clone
            ParticleSystem explosion = clone.GetComponent<ParticleSystem>();
            explosion.Play();

            // Grab the AudioSource from that exploison prefab clone
            AudioSource audio = clone.GetComponent<AudioSource>();
            audio.Play();


            Scoreboard.score += 20;
            // Destroy object
            Destroy(gameObject);
            
        }
    }

}
