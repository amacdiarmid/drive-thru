using UnityEngine;
using System.Collections;

public class endGame : MonoBehaviour {

	public float levelTime = 0.0f;
	public float oneStarTime = 10.0f;
	public float twoStarTime = 20.0f;
	public float threeStarTime = 30.0f;
	public float fourStarTime = 40.0f;
	public float fiveStarTime = 50.0f;

	private bool finished;
	private bool noStar;
	private bool oneStar;
	private bool twoStar;
	private bool threeStar;
	private bool fourStar;
	private bool fiveStar;

	// Use this for initialization
	void Start () {
		finished = false;
		noStar = false;
		oneStar = false;
		twoStar = false;
		threeStar = false;
		fourStar = false;
		fiveStar = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(!finished){
		levelTime += Time.deltaTime;
		}

	}

	void OnCollisionStay2D(Collision2D col){
		if(col.gameObject.name=="Finish"){
			if(levelTime > 0 && levelTime <= fiveStarTime ){
				finished = true;
				fiveStar = true;
			}
			if(levelTime > fiveStarTime && levelTime <= fourStarTime ){
				finished = true;
				fourStar = true;
			}
			if(levelTime > fourStarTime && levelTime <= threeStarTime){
				finished = true;
				threeStar = true;
			}
			if(levelTime > threeStarTime && levelTime <= twoStarTime ){
				finished = true;
				twoStar = true;
			}
			if(levelTime > twoStarTime && levelTime <= oneStarTime){
				finished = true;
				oneStar = true;
			}
			if(levelTime > oneStarTime){
				finished = true;
				noStar = true;
			}
		}
	}

	void OnGUI(){
		GUI.Box(new Rect(10, 10, 50, 20), "" + levelTime.ToString("0"));

		if(fiveStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You get five stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}
		if(fourStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You get four stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}
		if(threeStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You get three stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}
		if(twoStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You get two stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}
		if(oneStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You get one stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}
		if(noStar){
			GUI.Label(new Rect(100, 50, 400, 20), "You got no stars!");
			if(GUI.Button(new Rect(100, 80, 400, 20), "Play Again!")){
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(100, 110, 400, 20), "Quit Game!")){
				Application.LoadLevel("start");
			}
		}

	}

}
