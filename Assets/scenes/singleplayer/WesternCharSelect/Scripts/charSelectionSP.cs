using UnityEngine;
using System.Collections;

public class charSelectionSP : MonoBehaviour {

	public int player1car;
	public int player1character;
	

	// Use this for initialization
	void Start () {
		player1car=0;
		player1character=0;
	
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this);
	}
}
