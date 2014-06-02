using UnityEngine;
using System.Collections;

public class spawntriggerscript : MonoBehaviour
{	
	//on collision with object 
	void OnTriggerEnter2D (Collider2D respawn)
	{
		//post to debug
		Debug.Log ("respawn collider hit");	

		//if the object is the player(s)
		if (respawn.gameObject.name == "player 1")
		{
			//fin the gameobject called MAN (can be changed in final Vesion)
			GameObject goOne = GameObject.Find("player 1");
			//finf the scrips called characterController (changed in final version)
			playerOne callrespawnOne = (playerOne) goOne.GetComponent(typeof(playerOne));
			//in found script call the method called respawn
			callrespawnOne.setDeadOne ();
		}
		//if the object is the player(s)
		if (respawn.gameObject.name == "player 2")
		{
			//fin the gameobject called MAN (can be changed in final Vesion)
			GameObject goTwo = GameObject.Find("player 2");
			//finf the scrips called characterController (changed in final version)
			playerTwo callrespawnTwo = (playerTwo) goTwo.GetComponent(typeof(playerTwo));
			//in found script call the method called respawn
			callrespawnTwo.setDeadTwo ();
		}
	}
}