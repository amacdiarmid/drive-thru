using UnityEngine;
using System.Collections;

public class characterselect1P : MonoBehaviour {

	public AudioClip click;

	public int charNum;
	public int carNum;

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

		GameObject selectCar = GameObject.Find("character spawner");
		Debug.Log("character " +charNum +" pressed");
		selectCar.GetComponent<characterSelectionSelectionScript>().player1character=charNum;
		selectCar.GetComponent<characterSelectionSelectionScript>().player1car=carNum;

		if (carNum == 1){
			Application.LoadLevel("WesternLevel");
		}else if (carNum == 2){
			Application.LoadLevel("SpaceLevel");
		}else if (carNum == 3){
			Application.LoadLevel("CityLevel");
		}
	}
}
