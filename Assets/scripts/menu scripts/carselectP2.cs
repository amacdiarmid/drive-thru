using UnityEngine;
using System.Collections;

public class carselectP2 : MonoBehaviour {

	public AudioClip click;

	public int charNum;
	public int carNum;
	
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

		GameObject selectCar = GameObject.Find("character spawner");
		selectCar.GetComponent<characterSelectionSelectionScript>().player2character=charNum;
		selectCar.GetComponent<characterSelectionSelectionScript>().player2car=carNum;
		Application.LoadLevel("multiplayer");
	}
}
