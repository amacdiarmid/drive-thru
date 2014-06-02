using UnityEngine;
using System.Collections;

public class carDeath : MonoBehaviour {

	private bool dead;

	// Use this for initialization
	void Start () {
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "DeathTrigger"){
			dead = true;
			Debug.Log ("Dead");
		}
	}

	void OnGUI(){
		if(dead == true){
		GUI.Label(new Rect(100, 50, 400, 20), "You Died!");
		if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
			Application.LoadLevel(Application.loadedLevel);
		}
		if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
		}
	}
	}

}
