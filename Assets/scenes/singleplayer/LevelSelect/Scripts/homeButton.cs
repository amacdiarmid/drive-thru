using UnityEngine;
using System.Collections;

public class homeButton : MonoBehaviour {

	public AudioClip click;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

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
		Application.LoadLevel("home");
	}
}
