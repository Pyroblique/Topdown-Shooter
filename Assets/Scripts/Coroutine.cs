using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour 
{
	bool ticking = true;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Clock ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Clock()
	{
		while (ticking) 
		{
			print ("Tick");
			yield return new WaitForSeconds (1);
			print ("Tock");
			yield return new WaitForSeconds (1);
		}
	}
}
