using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour {
	
	public GameObject laser;


	
	// Update is called once per frame
	void Update () 
	{
        // To shoot
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(laser, transform.position * 0.9f, transform.rotation);
		}
	}
}
