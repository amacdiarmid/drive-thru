using UnityEngine;
using System.Collections;

public class scoreScript : MonoBehaviour {

	public int player1Score = 0;
	public int player2Score = 0;
	public int finalScore = 5;

	public bool player1wins=false;
	public bool player2wins=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(player1Score == finalScore){
			player1wins=true;
		}
		else if (player2Score == finalScore){
			player2wins=false;
		}
	
	}

	public void playerOneScore()
	{
		player1Score++;
	}

	public void playerTwoScore()
	{
		player2Score++;
	}

	void OnGUI(){
		GUI.Box(new Rect(10, 10, 150, 20), "player 1 score: " + player1Score);
		GUI.Box(new Rect(10, 30, 150, 20), "player 2 score: " + player2Score);
		
		if(player1wins){
			GUI.Label(new Rect(100, 50, 400, 20), "player 1 wins!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "home")){
				Application.LoadLevel("home");
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.Quit();
			}
		}
		if(player2wins){
			GUI.Label(new Rect(100, 50, 400, 20), "player 2 wins!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "home")){
				Application.LoadLevel("home");
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.Quit();
			}
		}
	}
}
