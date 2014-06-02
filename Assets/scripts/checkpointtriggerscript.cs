using UnityEngine;
using System.Collections;

public class checkpointtriggerscript : MonoBehaviour {

	public bool ranGenDone = false;

	//on collision with object 
	void OnTriggerEnter2D (Collider2D checkpoint)
	{
		//if the object is the player(s)
		if (checkpoint.gameObject.tag == "Player" && ranGenDone == false)
		{
			//post to debug
			Debug.Log ("checkpoint collider hit");	

			//fin the gameobject with tag player
			GameObject goone = GameObject.Find("player 1");
			//finf the scrips called playerOne
			playerOne callcheckpointone = (playerOne) goone.GetComponentInChildren(typeof(playerOne));
			//in found script call the method called respawn
			callcheckpointone.checkpointOne();
			callcheckpointone.setSpawnedOne();

			//fin the gameobject with tag player
			GameObject gotwo = GameObject.Find("player 2");
			//finf the scrips called playerTwo
			playerTwo callcheckpointtwo = (playerTwo) gotwo.GetComponentInChildren(typeof(playerTwo));
			//in found script call the method called respawn
			callcheckpointtwo.checkpointTwo();
			callcheckpointtwo.setSpawnedTwo();

			//fin the gameobject called ran tile gen 
			GameObject tile = GameObject.Find("ran tile gen");
			//finf the scrips called rantilegen
			rantilegen callgentile = (rantilegen) tile.GetComponent(typeof(rantilegen));
			//in found script call the method called respawn
			callgentile.spawntiles();

			ranGenDone = true;
		}
	}
}
