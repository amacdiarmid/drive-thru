using UnityEngine;
using System.Collections;

public class carselect : MonoBehaviour {

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
		selectCar.GetComponent<characterSelectionSelectionScript>().player1character=charNum;
		selectCar.GetComponent<characterSelectionSelectionScript>().player1car=carNum;
		Application.LoadLevel("multiplayer character select player2");
	}
}