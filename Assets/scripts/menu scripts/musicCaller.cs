using UnityEngine;
using System.Collections;

public class musicCaller : MonoBehaviour {

	public int musicNumber;

	// Use this for initialization
	void Start () {

		GameObject music = GameObject.Find("music");
		musicScript callchange = (musicScript) music.GetComponent(typeof(musicScript));

		if(musicNumber == 1){
			callchange.playMultiplayer();
		}else if (musicNumber == 2){
			callchange.playSciFi();
		}else if (musicNumber == 3){
			callchange.playGangster();
		}else if (musicNumber == 4){
			callchange.playWestern();
		}else if (musicNumber == 5) {
			callchange.playMain();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
