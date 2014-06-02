using UnityEngine;
using System.Collections;

public class carSelectSPspace : MonoBehaviour {

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

		GameObject selectCar = GameObject.Find("CharacterSpawner");
		selectCar.GetComponent<charSelectionSP>().player1character=charNum;
		selectCar.GetComponent<charSelectionSP>().player1car=carNum;
		Debug.Log(charNum + " " + carNum);

		Application.LoadLevel("SpaceLevel");
	}
}