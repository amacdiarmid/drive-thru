using UnityEngine;
using System.Collections;

public class startMenu : MonoBehaviour {

	public Texture2D singleplayerButton;
	public GUIStyle singleplayerButtonStyle;
	public Texture2D settingsButton;
	public GUIStyle settingsButtonStyle;
	public Texture2D AchivementsButton;
	public GUIStyle AchivementsButtonStyle;
	public Texture2D multiplayerButton;
	public GUIStyle multiplayerButtonStyle;

	void OnGUI(){
		if (GUI.RepeatButton(new Rect(0, 0 , 200, 200), singleplayerButton, singleplayerButtonStyle)){
			Application.LoadLevel("");
		}
		if (GUI.RepeatButton(new Rect(0, 0, 200, 200), settingsButton, settingsButtonStyle)){
			Application.LoadLevel("");
		}
		if (GUI.RepeatButton(new Rect(0, 0, 200, 200), AchivementsButton, AchivementsButtonStyle)){
			Application.LoadLevel("");
		}
		if (GUI.RepeatButton(new Rect(0, 0, 200, 200), multiplayerButton, multiplayerButtonStyle)){
			Application.LoadLevel("");
		}
	}
}
