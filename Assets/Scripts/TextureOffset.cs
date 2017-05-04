using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour {
	// Scroll the background based on time
	public Renderer background;
	float scrollSpeed = 5f;

	float offset;
	float rotate;

	// Use this for initialization
	void Start () {
		background = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update () {
		// To make the image repeat
		offset += (Time.deltaTime * scrollSpeed) / 10f;
		background.material.SetTextureOffset ("_MainTex", new Vector2 (0, -offset));
	}
}
