using UnityEngine;
using System.Collections;

public class buttonpress : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this);
	}

	public void button(){
		audio.Play();
	}
}