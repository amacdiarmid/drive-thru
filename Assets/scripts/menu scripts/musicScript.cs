using UnityEngine;
using System.Collections;

public class musicScript : MonoBehaviour {

	public AudioClip western;
	public AudioClip sciFi;
	public AudioClip gangster;
	public AudioClip mainMenu;

	public int tempmusic;

	// Use this for initialization
	void Start () {
		audio.clip = mainMenu;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this);
	
	}

	public void playWestern(){
		audio.clip = western;
		audio.Play();
	}

	public void playSciFi(){
		audio.clip = sciFi;
		audio.Play();
	}

	public void playGangster(){
		audio.clip = gangster;
		audio.Play();
	}

	public void playMain(){
		audio.clip = mainMenu;
		audio.Play();
	}

	public void playMultiplayer(){
		tempmusic = Random.Range(1,3);

		if(tempmusic==1){
			audio.clip = gangster;
			audio.Play();
			Invoke("playMultiplayer",audio.clip.length);
		}else if(tempmusic==2){
			audio.clip = sciFi;
			audio.Play();
			Invoke("playMultiplayer",audio.clip.length);
		}else if(tempmusic==3){
			audio.clip = western;
			audio.Play();
			Invoke("playMultiplayer",audio.clip.length);
		}
	}
}
