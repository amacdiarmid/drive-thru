﻿using UnityEngine;
using System.Collections;

public class settingsButton : MonoBehaviour {

	public AudioClip click;

	void OnMouseEnter()
	{
		renderer.material.color = Color.grey;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}
	
	void OnMouseUp()
	{
		audio.PlayOneShot(click);
		
		Application.LoadLevel("settings");
	}
}
