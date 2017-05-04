using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour 
{
    public GameObject explosionPrefab;
    public Rigidbody rb;
    public float playerSpeed = 20f;
    public bool grounded = false;
    public int lives = 5;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();


		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			// Add a force to the Rigidbody.
			rb.AddForce(Vector3.forward * 10f);
		}
		if(Input.GetKey(KeyCode.S))
		{
			rb.AddForce(Vector3.forward * -10f);
		}
		if(Input.GetKey(KeyCode.A))
		{
			rb.AddForce(Vector3.left * 10f);
		}
		if(Input.GetKey(KeyCode.D))
		{
			rb.AddForce(Vector3.left * -10f);
		}
	}

	public void Respawn()
	{
        // To respawn the ship
        rb.velocity = Vector3.zero;
		rb.isKinematic = false;
		transform.position = new Vector3(0, 5.16f, -2.5f);
	}

	void OnTriggerEnter(Collider other) 
	{
        // Particle explosion 
        GameObject clone = Instantiate(explosionPrefab);
        clone.transform.position = transform.position;
        ParticleSystem explosion = clone.GetComponent<ParticleSystem>();
        explosion.Play();
        // Subtract one life
        Scoreboard.lives -= 1;
        // Explosion sound-effect
        AudioSource audio = clone.GetComponent<AudioSource>();
        audio.Play();
        // To respawn when hitting an obstacle
        Respawn ();
        
	}

    
}
