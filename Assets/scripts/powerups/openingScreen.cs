using UnityEngine;
using System.Collections;

public class openingScreen : MonoBehaviour {

	public Texture playButton;
	public GUIStyle buttonSkin;
	public float width = 200;
	public float height = 200;

	void OnGUI() {
		if (GUI.RepeatButton(new Rect((Screen.width/2), (Screen.height/2), width, height), playButton, buttonSkin)){
			Debug.Log("Clicked the play button");
			Application.LoadLevel("GameScene");
		}
	}
}
